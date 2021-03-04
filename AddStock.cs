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

namespace TickInke
{
    public partial class AddStock : Form
    {
        string cmdstr = "SELECT * FROM Inventory";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= M:\IT\Accesories\Ink Inventory\Ink.accdb");
        public AddStock()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                finalamt = tblamt + amount;
                string updt = "UPDATE Inventory SET Amount=" + finalamt + " WHERE Barcode ='" + bcd + " '";
                cmd.CommandText = updt;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Item added to stock levels");
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
                da.Fill(ds, "[Inventory]");

                con.Close();

                textBox1.Clear();
                textBox2.Clear();
            }
            else
                MessageBox.Show("Please enter a Barcode and Amount!");
            this.Close();
        }
    }
}
