namespace Beit_Solutions_ERP_v1._1.Forms
{
    partial class FrmLocations
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
            this.components = new System.ComponentModel.Container();
            this.lblJurisdictionName = new System.Windows.Forms.Label();
            this.btnRemoveLocation = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClearFields = new System.Windows.Forms.Button();
            this.txtLocationId = new System.Windows.Forms.TextBox();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.btnUpdateLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtJurisdictionName = new System.Windows.Forms.TextBox();
            this.dgvStateProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            this.dgvJurisdiction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxJurisdiction = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblJurisdictionNameType = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJurisdictionName
            // 
            this.lblJurisdictionName.AutoSize = true;
            this.lblJurisdictionName.Location = new System.Drawing.Point(26, 119);
            this.lblJurisdictionName.Name = "lblJurisdictionName";
            this.lblJurisdictionName.Size = new System.Drawing.Size(93, 13);
            this.lblJurisdictionName.TabIndex = 40;
            this.lblJurisdictionName.Text = "Jurisdiction Name:";
            // 
            // btnRemoveLocation
            // 
            this.btnRemoveLocation.Location = new System.Drawing.Point(486, 85);
            this.btnRemoveLocation.Name = "btnRemoveLocation";
            this.btnRemoveLocation.Size = new System.Drawing.Size(100, 33);
            this.btnRemoveLocation.TabIndex = 39;
            this.btnRemoveLocation.Text = "Remove Location";
            this.btnRemoveLocation.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(135, 138);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(100, 33);
            this.btnClearFields.TabIndex = 38;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            // 
            // txtLocationId
            // 
            this.txtLocationId.Location = new System.Drawing.Point(135, 33);
            this.txtLocationId.Name = "txtLocationId";
            this.txtLocationId.Size = new System.Drawing.Size(206, 20);
            this.txtLocationId.TabIndex = 37;
            // 
            // lblLocationId
            // 
            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Location = new System.Drawing.Point(26, 40);
            this.lblLocationId.Name = "lblLocationId";
            this.lblLocationId.Size = new System.Drawing.Size(65, 13);
            this.lblLocationId.TabIndex = 36;
            this.lblLocationId.Text = "Location ID:";
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.Location = new System.Drawing.Point(592, 85);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(100, 33);
            this.btnUpdateLocation.TabIndex = 35;
            this.btnUpdateLocation.Text = "Update Location";
            this.btnUpdateLocation.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(380, 85);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(100, 33);
            this.btnAddLocation.TabIndex = 34;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 33);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvAddress
            // 
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            // 
            // dgvCountry
            // 
            this.dgvCountry.HeaderText = "Country";
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.ReadOnly = true;
            // 
            // txtJurisdictionName
            // 
            this.txtJurisdictionName.Location = new System.Drawing.Point(135, 112);
            this.txtJurisdictionName.Name = "txtJurisdictionName";
            this.txtJurisdictionName.Size = new System.Drawing.Size(206, 20);
            this.txtJurisdictionName.TabIndex = 41;
            // 
            // dgvStateProvince
            // 
            this.dgvStateProvince.HeaderText = "Jurisdiction Name";
            this.dgvStateProvince.Name = "dgvStateProvince";
            this.dgvStateProvince.ReadOnly = true;
            // 
            // dgCity
            // 
            this.dgCity.HeaderText = "City";
            this.dgCity.Name = "dgCity";
            this.dgCity.ReadOnly = true;
            // 
            // dgLocationId
            // 
            this.dgLocationId.HeaderText = "Location ID";
            this.dgLocationId.Name = "dgLocationId";
            this.dgLocationId.ReadOnly = true;
            // 
            // dgvLocations
            // 
            this.dgvLocations.AllowUserToAddRows = false;
            this.dgvLocations.AllowUserToDeleteRows = false;
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgLocationId,
            this.dgCity,
            this.dgvJurisdiction,
            this.dgvStateProvince,
            this.dgvCountry,
            this.dgvAddress});
            this.dgvLocations.Location = new System.Drawing.Point(29, 177);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.ReadOnly = true;
            this.dgvLocations.Size = new System.Drawing.Size(663, 266);
            this.dgvLocations.TabIndex = 32;
            // 
            // dgvJurisdiction
            // 
            this.dgvJurisdiction.HeaderText = "Jurisdiction Type";
            this.dgvJurisdiction.Name = "dgvJurisdiction";
            this.dgvJurisdiction.ReadOnly = true;
            // 
            // comboBoxJurisdiction
            // 
            this.comboBoxJurisdiction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJurisdiction.FormattingEnabled = true;
            this.comboBoxJurisdiction.Items.AddRange(new object[] {
            "",
            "Province",
            "State",
            "County"});
            this.comboBoxJurisdiction.Location = new System.Drawing.Point(135, 85);
            this.comboBoxJurisdiction.Name = "comboBoxJurisdiction";
            this.comboBoxJurisdiction.Size = new System.Drawing.Size(206, 21);
            this.comboBoxJurisdiction.TabIndex = 31;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(486, 59);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 20);
            this.txtAddress.TabIndex = 30;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(486, 33);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(206, 20);
            this.txtCountry.TabIndex = 29;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(135, 59);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(206, 20);
            this.txtCity.TabIndex = 28;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(377, 66);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(377, 40);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 26;
            this.lblCountry.Text = "Country:";
            // 
            // lblJurisdictionNameType
            // 
            this.lblJurisdictionNameType.AutoSize = true;
            this.lblJurisdictionNameType.Location = new System.Drawing.Point(26, 93);
            this.lblJurisdictionNameType.Name = "lblJurisdictionNameType";
            this.lblJurisdictionNameType.Size = new System.Drawing.Size(89, 13);
            this.lblJurisdictionNameType.TabIndex = 25;
            this.lblJurisdictionNameType.Text = "Jurisdiction Type:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(26, 66);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "City:";
            // 
            // FrmLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 486);
            this.Controls.Add(this.lblJurisdictionName);
            this.Controls.Add(this.btnRemoveLocation);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtLocationId);
            this.Controls.Add(this.lblLocationId);
            this.Controls.Add(this.btnUpdateLocation);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJurisdictionName);
            this.Controls.Add(this.dgvLocations);
            this.Controls.Add(this.comboBoxJurisdiction);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblJurisdictionNameType);
            this.Controls.Add(this.lblCity);
            this.Name = "FrmLocations";
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.FrmLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJurisdictionName;
        private System.Windows.Forms.Button btnRemoveLocation;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.TextBox txtLocationId;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.Button btnUpdateLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtJurisdictionName;
        private System.Windows.Forms.DataGridView dgvLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvJurisdiction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStateProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.ComboBox comboBoxJurisdiction;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblJurisdictionNameType;
        private System.Windows.Forms.Label lblCity;
    }
}