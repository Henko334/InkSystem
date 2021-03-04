using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace TickInke
{
    public partial class RemoveStock : Form
    {
        string cmdtxt = "SELECT * FROM Inventory";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= M:\IT\Accesories\Ink Inventory\Ink.accdb");

        public RemoveStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                con.Open();
                int amount = 0;
                int tblamt = 0;
                int finalamt = 0;
                amount = Convert.ToInt32(textBox2.Text);

                string bcd = textBox1.Text;

                string getamt = "SELECT Amount FROM Inventory WHERE Barcode= '" + bcd + " '";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = getamt;

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tblamt = Convert.ToInt32(reader["Amount"]);
                }

                con.Close();


                con.Open();
                cmd.Connection = con;
                finalamt = tblamt - amount;
                string updt = "UPDATE Inventory SET Amount=" + finalamt + " WHERE Barcode ='" + bcd + " '";
                cmd.CommandText = updt;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item removed from stock levels");
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmdtxt, con);
                da.Fill(ds, "[Inventory]");
                con.Close();
                textBox1.Clear();
                textBox2.Clear();

                if (finalamt < 0)
                {
                    MessageBox.Show("Stock cant be less than 0!");
                    finalamt = 0;
                }
                else if (finalamt == 1 || finalamt == 0)
                {
                    string prod = " ";
                    string printer = " ";
                    con.Open();
                    string pdcd = "SELECT Part_Num FROM Inventory WHERE Barcode= '" + bcd + " '";
                    string pntr = "SELECT Printer_Type FROM Inventory WHERE Barcode= '" + bcd + " '";

                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = pdcd;
                    OleDbDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        prod = reader2["Part_Num"].ToString();
                    }
                    con.Close();

                    con.Open();
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = con;
                    cmd3.CommandText = pntr;
                    OleDbDataReader reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        printer = reader3["Printer_Type"].ToString();
                    }
                    con.Close();


                    MessageBox.Show("Stock is getting low, order more!");

                    //Sending mail to support to say ink is low
                    var fromAddress = new MailAddress("genelouwkoor@gmail.com", "Ink System");
                    var toAddress = new MailAddress("support@genelouw.co.za", "Support");
                    const string fromPassword = "Skool123";
                    const string subject = "Bestel Ink";
                    string body = "";
                    body = "The stock of: " + prod + " for: " + printer + " is " + finalamt + ".";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                }
            }
            else
                MessageBox.Show("Please enter a Barcode and Amount!");

            this.Close();
        }
    }
}
