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
    
    public partial class InkInvent : Form
    {
        public string cmdstr = "SELECT * FROM Inventory";
        public OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= M:\IT\Accesories\Ink Inventory\Ink.accdb");

        public InkInvent()
        {
            InitializeComponent();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Inventory]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Inventory]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string bcd = textBox1.Text;
                con.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Inventory  WHERE Barcode= '" + bcd + " '", con);
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
                MessageBox.Show("The chosen item was deleted from the database");
            }
            else
                MessageBox.Show("Please enter the barcode of the Item to delete!");

            OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Inventory]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
            textBox1.Clear();

        }
    }
}
