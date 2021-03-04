using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickInke
{
    
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool openchild = false;

            if (!MdiChildren.Any())
            {
                openchild = true;                    
            }
            else
                this.ActiveMdiChild.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Tickets")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }

            }
            if (isOpen == false)
            {
                TiekView tiekView = new TiekView();
                tiekView.MdiParent = this;
                tiekView.Dock = DockStyle.Fill;
                tiekView.Show();
            }
        }

        private void addNewTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "AddTicket")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddTicket addTicket = new AddTicket();
                addTicket.MdiParent = this;
                addTicket.Show();
            }
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "Ink Inventory")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                InkInvent ink = new InkInvent();
                ink.MdiParent = this;
                ink.Dock = DockStyle.Fill;
                ink.Show();
            }
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "AddStock")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddStock addStock = new AddStock();
                addStock.MdiParent = this;
                addStock.Show();
            }
        }

        private void removeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "RemoveStock")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                RemoveStock removeStock = new RemoveStock();
                removeStock.MdiParent = this;
                removeStock.Show();
            }
        }

        private void addNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "NewInk")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }                
            }
            if(isOpen == false)
            {
                NewInk newInk = new NewInk();
                newInk.MdiParent = this;
                newInk.Show();
            }
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLowStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LowStock")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                LowStock lowStock = new LowStock();
                lowStock.MdiParent = this;
                lowStock.Show();
            }
        }
    }
}
