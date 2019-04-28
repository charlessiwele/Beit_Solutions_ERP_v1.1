namespace Beit_Solutions_ERP_v1._1.Forms
{
    partial class FrmRoles
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
            this.lblRoleId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRoleId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleNarration = new System.Windows.Forms.TextBox();
            this.lblRoleNarration = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoleId
            // 
            this.lblRoleId.AutoSize = true;
            this.lblRoleId.Location = new System.Drawing.Point(29, 53);
            this.lblRoleId.Name = "lblRoleId";
            this.lblRoleId.Size = new System.Drawing.Size(46, 13);
            this.lblRoleId.TabIndex = 0;
            this.lblRoleId.Text = "Role ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(32, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtRoleId
            // 
            this.txtRoleId.Location = new System.Drawing.Point(129, 46);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.Size = new System.Drawing.Size(140, 20);
            this.txtRoleId.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 163);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(129, 72);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(140, 20);
            this.txtRoleName.TabIndex = 5;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(29, 79);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(63, 13);
            this.lblRoleName.TabIndex = 4;
            this.lblRoleName.Text = "Role Name:";
            // 
            // txtRoleNarration
            // 
            this.txtRoleNarration.Location = new System.Drawing.Point(129, 98);
            this.txtRoleNarration.Name = "txtRoleNarration";
            this.txtRoleNarration.Size = new System.Drawing.Size(140, 20);
            this.txtRoleNarration.TabIndex = 7;
            // 
            // lblRoleNarration
            // 
            this.lblRoleNarration.AutoSize = true;
            this.lblRoleNarration.Location = new System.Drawing.Point(29, 105);
            this.lblRoleNarration.Name = "lblRoleNarration";
            this.lblRoleNarration.Size = new System.Drawing.Size(88, 13);
            this.lblRoleNarration.TabIndex = 6;
            this.lblRoleNarration.Text = "Role Description:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 385);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRoleNarration);
            this.Controls.Add(this.lblRoleNarration);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRoleId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblRoleId);
            this.Name = "FrmRoles";
            this.Text = "FrmRoles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleNarration;
        private System.Windows.Forms.Label lblRoleNarration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}