
namespace TickInke
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inkInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLowStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.inkInventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTicketsToolStripMenuItem,
            this.addNewTicketToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // viewTicketsToolStripMenuItem
            // 
            this.viewTicketsToolStripMenuItem.Name = "viewTicketsToolStripMenuItem";
            this.viewTicketsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewTicketsToolStripMenuItem.Text = "View Tickets";
            this.viewTicketsToolStripMenuItem.Click += new System.EventHandler(this.viewTicketsToolStripMenuItem_Click);
            // 
            // addNewTicketToolStripMenuItem
            // 
            this.addNewTicketToolStripMenuItem.Name = "addNewTicketToolStripMenuItem";
            this.addNewTicketToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewTicketToolStripMenuItem.Text = "Add New Ticket";
            this.addNewTicketToolStripMenuItem.Click += new System.EventHandler(this.addNewTicketToolStripMenuItem_Click);
            // 
            // inkInventoryToolStripMenuItem
            // 
            this.inkInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.addStockToolStripMenuItem,
            this.removeStockToolStripMenuItem,
            this.addNewStockToolStripMenuItem,
            this.showLowStockToolStripMenuItem});
            this.inkInventoryToolStripMenuItem.Name = "inkInventoryToolStripMenuItem";
            this.inkInventoryToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.inkInventoryToolStripMenuItem.Text = "Ink Inventory";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // removeStockToolStripMenuItem
            // 
            this.removeStockToolStripMenuItem.Name = "removeStockToolStripMenuItem";
            this.removeStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeStockToolStripMenuItem.Text = "Remove Stock";
            this.removeStockToolStripMenuItem.Click += new System.EventHandler(this.removeStockToolStripMenuItem_Click);
            // 
            // addNewStockToolStripMenuItem
            // 
            this.addNewStockToolStripMenuItem.Name = "addNewStockToolStripMenuItem";
            this.addNewStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewStockToolStripMenuItem.Text = "Add New Item";
            this.addNewStockToolStripMenuItem.Click += new System.EventHandler(this.addNewStockToolStripMenuItem_Click);
            // 
            // showLowStockToolStripMenuItem
            // 
            this.showLowStockToolStripMenuItem.Name = "showLowStockToolStripMenuItem";
            this.showLowStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLowStockToolStripMenuItem.Text = "View Low Stock";
            this.showLowStockToolStripMenuItem.Click += new System.EventHandler(this.showLowStockToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TickInke.Properties.Resources.FRl21Y;
            this.ClientSize = new System.Drawing.Size(886, 547);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inkInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLowStockToolStripMenuItem;
    }
}

