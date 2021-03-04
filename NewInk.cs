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
    public partial class NewInk : Form
    {
        string cmdtxt = "SELECT * FROM Inventory";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= M:\IT\Accesories\Ink Inventory\Ink.accdb");

        public NewInk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string color = textBox3.Text;
            string part_num = textBox2.Text;
            string ptr = textBox4.Text;
            string bcd = textBox6.Text;
            int amount = Convert.ToInt32(textBox5.Text);

            OleDbCommand cmd = new OleDbCommand("INSERT into Inventory (ID, Part_Num, Color, Printer_Type, Amount, Barcode) Values('" + id + "','" + part_num + "','" + color + "','" + ptr + "', " + amount + ",'" + bcd + "')");
            cmd.Connection = con;

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                cmd.Parameters.Add(@"ID", OleDbType.VarChar).Value = id;
                cmd.Parameters.Add(@"Color", OleDbType.VarChar).Value = color;
                cmd.Parameters.Add(@"Part_Num", OleDbType.VarChar).Value = part_num;
                cmd.Parameters.Add(@"Amount", OleDbType.VarChar).Value = amount;
                cmd.Parameters.Add(@"Printer_Type", OleDbType.VarChar).Value = ptr;
                cmd.Parameters.Add(@"Barcode", OleDbType.VarChar).Value = bcd;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Stock added");
                    con.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message + "\n Please make sure all the fields are filled in");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            con.Close();

            this.Close();
        }
    }
    
}
