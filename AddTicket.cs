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
    public partial class AddTicket : Form
    {
        string contxt = "SELECT * FROM Tickets";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= M:\IT\Accesories\Ink Inventory\TicketsDB.accdb");
        public AddTicket()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string teacher = textBox2.Text;
            string problem = textBox3.Text;
            string status = comboBox1.Text;

            OleDbCommand cmd = new OleDbCommand("INSERT into Tickets (ID, Teacher, Problem, Status) Values('" + id + "', '" + teacher + "','" + problem + "','" + status + "')");
            cmd.Connection = con;

            con.Open();
            if (con.State == ConnectionState.Open)
            {
                cmd.Parameters.Add(@"ID", OleDbType.VarChar).Value = id;
                cmd.Parameters.Add(@"Teacher", OleDbType.VarChar).Value = teacher;
                cmd.Parameters.Add(@"Problem", OleDbType.VarChar).Value = problem;
                cmd.Parameters.Add(@"Status", OleDbType.VarChar).Value = status;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New ticket added");
                    con.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.Text = "";
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message + "\n Please make all the fields are filled in!");
                    con.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
