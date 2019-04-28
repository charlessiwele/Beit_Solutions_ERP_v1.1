namespace Beit_Solutions_ERP_v1._1
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.businessSetupToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.maintainUsersToolStripMenuItem,
            this.registerUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // maintainUsersToolStripMenuItem
            // 
            this.maintainUsersToolStripMenuItem.Name = "maintainUsersToolStripMenuItem";
            this.maintainUsersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maintainUsersToolStripMenuItem.Text = "Maintain Users";
            this.maintainUsersToolStripMenuItem.Click += new System.EventHandler(this.maintainUsersToolStripMenuItem_Click);
            // 
            // registerUsersToolStripMenuItem
            // 
            this.registerUsersToolStripMenuItem.Name = "registerUsersToolStripMenuItem";
            this.registerUsersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerUsersToolStripMenuItem.Text = "Register Users";
            this.registerUsersToolStripMenuItem.Click += new System.EventHandler(this.registerUsersToolStripMenuItem_Click);
            // 
            // businessSetupToolStripMenuItem
            // 
            this.businessSetupToolStripMenuItem.Name = "businessSetupToolStripMenuItem";
            this.businessSetupToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.businessSetupToolStripMenuItem.Text = "Business Setup";
            this.businessSetupToolStripMenuItem.Click += new System.EventHandler(this.businessSetupToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsToolStripMenuItem,
            this.manageClientsToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // manageClientsToolStripMenuItem
            // 
            this.manageClientsToolStripMenuItem.Name = "manageClientsToolStripMenuItem";
            this.manageClientsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manageClientsToolStripMenuItem.Text = "Manage Clients";
            this.manageClientsToolStripMenuItem.Click += new System.EventHandler(this.manageClientsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 485);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "BeitPlex Hospitality ERP";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClientsToolStripMenuItem;
    }
}

