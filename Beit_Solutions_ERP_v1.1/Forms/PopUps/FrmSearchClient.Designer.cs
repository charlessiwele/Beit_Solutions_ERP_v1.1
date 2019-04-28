namespace Beit_Solutions_ERP_v1._1.Forms.PopUps
{
    partial class FrmSearchClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblAddressLine3 = new System.Windows.Forms.Label();
            this.lblNationalId = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgName,
            this.dgClientType,
            this.dgIdNumber,
            this.dgPhone,
            this.dgEmail});
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(233, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgClientType
            // 
            this.dgClientType.HeaderText = "Client Type";
            this.dgClientType.Name = "dgClientType";
            this.dgClientType.ReadOnly = true;
            // 
            // dgIdNumber
            // 
            this.dgIdNumber.HeaderText = "ID Number";
            this.dgIdNumber.Name = "dgIdNumber";
            this.dgIdNumber.ReadOnly = true;
            // 
            // dgPhone
            // 
            this.dgPhone.HeaderText = "Phone";
            this.dgPhone.Name = "dgPhone";
            this.dgPhone.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(261, 293);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 1;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(261, 260);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 2;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblAddressLine3
            // 
            this.lblAddressLine3.AutoSize = true;
            this.lblAddressLine3.Location = new System.Drawing.Point(261, 326);
            this.lblAddressLine3.Name = "lblAddressLine3";
            this.lblAddressLine3.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine3.TabIndex = 3;
            this.lblAddressLine3.Text = "Address Line 3";
            // 
            // lblNationalId
            // 
            this.lblNationalId.AutoSize = true;
            this.lblNationalId.Location = new System.Drawing.Point(261, 227);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(141, 13);
            this.lblNationalId.TabIndex = 6;
            this.lblNationalId.Text = "National ID | Registration No";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(261, 161);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(56, 13);
            this.lblNationality.TabIndex = 5;
            this.lblNationality.Text = "Nationality";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(261, 194);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(109, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender | Juristic Type";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(261, 95);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone ";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(261, 29);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 13);
            this.lblClientName.TabIndex = 8;
            this.lblClientName.Text = "Client Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(261, 62);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(84, 13);
            this.lblDob.TabIndex = 7;
            this.lblDob.Text = "DOB | Reg Date";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(261, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 227);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(233, 36);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(233, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 269);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(233, 36);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmSearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 354);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblNationalId);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddressLine3);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSearchClient";
            this.Text = "FrmSearchClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSearchClient_FormClosing);
            this.Load += new System.EventHandler(this.FrmSearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblAddressLine3;
        private System.Windows.Forms.Label lblNationalId;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
    }
}