using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace TickInke
{
    public partial class LowStock : Form
    {
        string cmdstr = "SELECT * FROM Inventory WHERE Amount <= 1";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= M:\IT\Accesories\Ink Inventory\Ink.accdb");
        Bitmap bm;
        public LowStock()
        {
            InitializeComponent();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Inventory]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void LowStock_Load(object sender, EventArgs e)
        {

        }

    }
}
