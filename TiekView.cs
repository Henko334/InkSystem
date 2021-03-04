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
    public partial class TiekView : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= M:\IT\Accesories\Ink Inventory\TicketsDB.accdb");
        string cmdstr = "SELECT * FROM Tickets";
        public TiekView()
        {
            InitializeComponent();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Tickets]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "Status")
            {
                int id = Convert.ToInt32(textBox1.Text);
                string upd = "UPDATE Tickets SET Status='" + comboBox1.Text + "'WHERE ID=" + id + " ";

                OleDbCommand update = new OleDbCommand();
                con.Open();
                update.Connection = con;
                update.CommandText = upd;
                update.ExecuteNonQuery();
                MessageBox.Show("Status of ticked has been updated.");
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
                da.Fill(ds, "[Tickets]");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();

                textBox1.Clear();
                comboBox1.Text = "Status";
            }
            else
                MessageBox.Show("Please enter an ID into the ID field and select the Status of the Ticket.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int id = Convert.ToInt32(textBox1.Text);
                string upd = "DELETE FROM Tickets WHERE ID=" + id + " ";

                OleDbCommand update = new OleDbCommand(upd, con);
                con.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Ticket Removed.");
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
                da.Fill(ds, "[Tickets]");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();

                textBox1.Clear();
                comboBox1.Text = "Status";
            }
            else
                MessageBox.Show("Please enter the ID of the ticket to remove!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Tickets]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
