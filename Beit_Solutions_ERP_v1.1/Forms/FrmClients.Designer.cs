namespace Beit_Solutions_ERP_v1._1.Forms
{
    partial class FrmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClients));
            this.grpbxClientSeach = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtClientNameSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtClientIdSearch = new System.Windows.Forms.TextBox();
            this.lblClientNameSearch = new System.Windows.Forms.Label();
            this.lblClientIdSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtNationalIdNo = new System.Windows.Forms.TextBox();
            this.lblNationalIdNo = new System.Windows.Forms.Label();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.lblClienSurname = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClientType = new System.Windows.Forms.ComboBox();
            this.lblClientType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber2 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClientSuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNationalIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgJuristicRegistrationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgJuristicTaxNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgJuristicType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhoneNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhoneNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpbxClientSeach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxClientSeach
            // 
            this.grpbxClientSeach.Controls.Add(this.btnSearch);
            this.grpbxClientSeach.Controls.Add(this.txtClientNameSearch);
            this.grpbxClientSeach.Controls.Add(this.btnClear);
            this.grpbxClientSeach.Controls.Add(this.txtClientIdSearch);
            this.grpbxClientSeach.Controls.Add(this.lblClientNameSearch);
            this.grpbxClientSeach.Controls.Add(this.lblClientIdSearch);
            this.grpbxClientSeach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbxClientSeach.Location = new System.Drawing.Point(93, 26);
            this.grpbxClientSeach.Name = "grpbxClientSeach";
            this.grpbxClientSeach.Size = new System.Drawing.Size(693, 94);
            this.grpbxClientSeach.TabIndex = 3;
            this.grpbxClientSeach.TabStop = false;
            this.grpbxClientSeach.Text = "Client Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(74, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtClientNameSearch
            // 
            this.txtClientNameSearch.Location = new System.Drawing.Point(403, 22);
            this.txtClientNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtClientNameSearch.Name = "txtClientNameSearch";
            this.txtClientNameSearch.Size = new System.Drawing.Size(187, 20);
            this.txtClientNameSearch.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(195, 44);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 27);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtClientIdSearch
            // 
            this.txtClientIdSearch.Location = new System.Drawing.Point(74, 21);
            this.txtClientIdSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtClientIdSearch.Name = "txtClientIdSearch";
            this.txtClientIdSearch.Size = new System.Drawing.Size(187, 20);
            this.txtClientIdSearch.TabIndex = 0;
            // 
            // lblClientNameSearch
            // 
            this.lblClientNameSearch.AutoSize = true;
            this.lblClientNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClientNameSearch.Location = new System.Drawing.Point(329, 29);
            this.lblClientNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblClientNameSearch.Name = "lblClientNameSearch";
            this.lblClientNameSearch.Size = new System.Drawing.Size(64, 13);
            this.lblClientNameSearch.TabIndex = 406;
            this.lblClientNameSearch.Text = "Client Name";
            // 
            // lblClientIdSearch
            // 
            this.lblClientIdSearch.AutoSize = true;
            this.lblClientIdSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClientIdSearch.Location = new System.Drawing.Point(17, 29);
            this.lblClientIdSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblClientIdSearch.Name = "lblClientIdSearch";
            this.lblClientIdSearch.Size = new System.Drawing.Size(47, 13);
            this.lblClientIdSearch.TabIndex = 404;
            this.lblClientIdSearch.Text = "Client ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(290, 200);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddress3);
            this.groupBox1.Controls.Add(this.lblAddress2);
            this.groupBox1.Controls.Add(this.txtAddress3);
            this.groupBox1.Controls.Add(this.txtAddress2);
            this.groupBox1.Controls.Add(this.txtNationalIdNo);
            this.groupBox1.Controls.Add(this.lblNationalIdNo);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.comboBoxNationality);
            this.groupBox1.Controls.Add(this.lblNationality);
            this.groupBox1.Controls.Add(this.txtClientSurname);
            this.groupBox1.Controls.Add(this.lblClienSurname);
            this.groupBox1.Controls.Add(this.txtAddress1);
            this.groupBox1.Controls.Add(this.lblAddress1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.dateTimePickerDob);
            this.groupBox1.Controls.Add(this.comboBoxClientType);
            this.groupBox1.Controls.Add(this.lblClientType);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtPhone2);
            this.groupBox1.Controls.Add(this.lblPhoneNumber2);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.comboBoxMaritalStatus);
            this.groupBox1.Controls.Add(this.lblMaritalStatus);
            this.groupBox1.Controls.Add(this.txtPhone1);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblDob);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.lblClientName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(93, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 233);
            this.groupBox1.TabIndex = 407;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Details";
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress3.Location = new System.Drawing.Point(309, 176);
            this.lblAddress3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(57, 13);
            this.lblAddress3.TabIndex = 443;
            this.lblAddress3.Text = "Address 3:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress2.Location = new System.Drawing.Point(309, 151);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(57, 13);
            this.lblAddress2.TabIndex = 442;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(471, 169);
            this.txtAddress3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(142, 20);
            this.txtAddress3.TabIndex = 441;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(471, 144);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(142, 20);
            this.txtAddress2.TabIndex = 440;
            // 
            // txtNationalIdNo
            // 
            this.txtNationalIdNo.Location = new System.Drawing.Point(149, 117);
            this.txtNationalIdNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNationalIdNo.Name = "txtNationalIdNo";
            this.txtNationalIdNo.Size = new System.Drawing.Size(142, 20);
            this.txtNationalIdNo.TabIndex = 438;
            // 
            // lblNationalIdNo
            // 
            this.lblNationalIdNo.AutoSize = true;
            this.lblNationalIdNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNationalIdNo.Location = new System.Drawing.Point(8, 122);
            this.lblNationalIdNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNationalIdNo.Name = "lblNationalIdNo";
            this.lblNationalIdNo.Size = new System.Drawing.Size(83, 13);
            this.lblNationalIdNo.TabIndex = 439;
            this.lblNationalIdNo.Text = "National ID No.:";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Items.AddRange(new object[] {
            "South Africa",
            "Other"});
            this.comboBoxNationality.Location = new System.Drawing.Point(149, 94);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(142, 21);
            this.comboBoxNationality.TabIndex = 437;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNationality.Location = new System.Drawing.Point(8, 101);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(62, 13);
            this.lblNationality.TabIndex = 436;
            this.lblNationality.Text = "Nationality.:";
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(149, 71);
            this.txtClientSurname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(142, 20);
            this.txtClientSurname.TabIndex = 433;
            // 
            // lblClienSurname
            // 
            this.lblClienSurname.AutoSize = true;
            this.lblClienSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClienSurname.Location = new System.Drawing.Point(8, 74);
            this.lblClienSurname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblClienSurname.Name = "lblClienSurname";
            this.lblClienSurname.Size = new System.Drawing.Size(84, 13);
            this.lblClienSurname.TabIndex = 434;
            this.lblClienSurname.Text = "Client Surname.:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(471, 119);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(142, 20);
            this.txtAddress1.TabIndex = 429;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress1.Location = new System.Drawing.Point(306, 126);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(57, 13);
            this.lblAddress1.TabIndex = 430;
            this.lblAddress1.Text = "Address 1:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(102, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 27);
            this.btnEdit.TabIndex = 427;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Location = new System.Drawing.Point(149, 140);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerDob.TabIndex = 426;
            // 
            // comboBoxClientType
            // 
            this.comboBoxClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientType.FormattingEnabled = true;
            this.comboBoxClientType.Items.AddRange(new object[] {
            "",
            "Natural Person",
            "Juristic Person"});
            this.comboBoxClientType.Location = new System.Drawing.Point(149, 22);
            this.comboBoxClientType.Name = "comboBoxClientType";
            this.comboBoxClientType.Size = new System.Drawing.Size(142, 21);
            this.comboBoxClientType.TabIndex = 425;
            this.comboBoxClientType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClientType_SelectedIndexChanged);
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClientType.Location = new System.Drawing.Point(8, 29);
            this.lblClientType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(63, 13);
            this.lblClientType.TabIndex = 424;
            this.lblClientType.Text = "Client Type:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(471, 96);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 420;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(306, 103);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 421;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(471, 71);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(142, 20);
            this.txtPhone2.TabIndex = 418;
            // 
            // lblPhoneNumber2
            // 
            this.lblPhoneNumber2.AutoSize = true;
            this.lblPhoneNumber2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhoneNumber2.Location = new System.Drawing.Point(306, 78);
            this.lblPhoneNumber2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPhoneNumber2.Name = "lblPhoneNumber2";
            this.lblPhoneNumber2.Size = new System.Drawing.Size(155, 13);
            this.lblPhoneNumber2.TabIndex = 419;
            this.lblPhoneNumber2.Text = "Fax Number/ Phone Number 2:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female",
            "Other"});
            this.comboBoxGender.Location = new System.Drawing.Point(471, 17);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(142, 21);
            this.comboBoxGender.TabIndex = 417;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGender.Location = new System.Drawing.Point(309, 25);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 416;
            this.lblGender.Text = "Gender:";
            // 
            // comboBoxMaritalStatus
            // 
            this.comboBoxMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaritalStatus.FormattingEnabled = true;
            this.comboBoxMaritalStatus.Items.AddRange(new object[] {
            "",
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
            this.comboBoxMaritalStatus.Location = new System.Drawing.Point(149, 166);
            this.comboBoxMaritalStatus.Name = "comboBoxMaritalStatus";
            this.comboBoxMaritalStatus.Size = new System.Drawing.Size(142, 21);
            this.comboBoxMaritalStatus.TabIndex = 415;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaritalStatus.Location = new System.Drawing.Point(8, 169);
            this.lblMaritalStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(74, 13);
            this.lblMaritalStatus.TabIndex = 414;
            this.lblMaritalStatus.Text = "Marital Status:";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(471, 46);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(142, 20);
            this.txtPhone1.TabIndex = 411;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(306, 53);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(90, 13);
            this.lblPhoneNumber.TabIndex = 412;
            this.lblPhoneNumber.Text = "Phone Number 1:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDob.Location = new System.Drawing.Point(8, 146);
            this.lblDob.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(33, 13);
            this.lblDob.TabIndex = 408;
            this.lblDob.Text = "DOB:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 27);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(195, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(149, 46);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(142, 20);
            this.txtClientName.TabIndex = 0;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClientName.Location = new System.Drawing.Point(8, 49);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(67, 13);
            this.lblClientName.TabIndex = 404;
            this.lblClientName.Text = "Client Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(32, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 192);
            this.panel1.TabIndex = 409;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgClientId,
            this.dgClientType,
            this.dgClientName,
            this.dgClientSuname,
            this.dgNationality,
            this.dgNationalIdNo,
            this.dgPassportNo,
            this.dgDob,
            this.dgMaritalStatus,
            this.dgGender,
            this.dgJuristicRegistrationNo,
            this.dgJuristicTaxNo,
            this.dgJuristicType,
            this.dgPhoneNumber1,
            this.dgPhoneNumber2,
            this.dgEmail});
            this.dataGridView1.Location = new System.Drawing.Point(11, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(798, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dgClientId
            // 
            this.dgClientId.HeaderText = "Client UID";
            this.dgClientId.Name = "dgClientId";
            this.dgClientId.ReadOnly = true;
            // 
            // dgClientType
            // 
            this.dgClientType.HeaderText = "Client Type";
            this.dgClientType.Name = "dgClientType";
            this.dgClientType.ReadOnly = true;
            // 
            // dgClientName
            // 
            this.dgClientName.HeaderText = "Client Name";
            this.dgClientName.Name = "dgClientName";
            this.dgClientName.ReadOnly = true;
            // 
            // dgClientSuname
            // 
            this.dgClientSuname.HeaderText = "Client Suname";
            this.dgClientSuname.Name = "dgClientSuname";
            this.dgClientSuname.ReadOnly = true;
            // 
            // dgNationality
            // 
            this.dgNationality.HeaderText = "Nationality";
            this.dgNationality.Name = "dgNationality";
            this.dgNationality.ReadOnly = true;
            // 
            // dgNationalIdNo
            // 
            this.dgNationalIdNo.HeaderText = "National ID No.";
            this.dgNationalIdNo.Name = "dgNationalIdNo";
            this.dgNationalIdNo.ReadOnly = true;
            // 
            // dgPassportNo
            // 
            this.dgPassportNo.HeaderText = "Passport No.";
            this.dgPassportNo.Name = "dgPassportNo";
            this.dgPassportNo.ReadOnly = true;
            // 
            // dgDob
            // 
            this.dgDob.HeaderText = "DOB";
            this.dgDob.Name = "dgDob";
            this.dgDob.ReadOnly = true;
            // 
            // dgMaritalStatus
            // 
            this.dgMaritalStatus.HeaderText = "Marital Status";
            this.dgMaritalStatus.Name = "dgMaritalStatus";
            this.dgMaritalStatus.ReadOnly = true;
            // 
            // dgGender
            // 
            this.dgGender.HeaderText = "Gender";
            this.dgGender.Name = "dgGender";
            this.dgGender.ReadOnly = true;
            // 
            // dgJuristicRegistrationNo
            // 
            this.dgJuristicRegistrationNo.HeaderText = "Juristic Registration No";
            this.dgJuristicRegistrationNo.Name = "dgJuristicRegistrationNo";
            this.dgJuristicRegistrationNo.ReadOnly = true;
            // 
            // dgJuristicTaxNo
            // 
            this.dgJuristicTaxNo.HeaderText = "Juristic Tax No";
            this.dgJuristicTaxNo.Name = "dgJuristicTaxNo";
            this.dgJuristicTaxNo.ReadOnly = true;
            // 
            // dgJuristicType
            // 
            this.dgJuristicType.HeaderText = "Juristic Type";
            this.dgJuristicType.Name = "dgJuristicType";
            this.dgJuristicType.ReadOnly = true;
            // 
            // dgPhoneNumber1
            // 
            this.dgPhoneNumber1.HeaderText = "Phone Number 1";
            this.dgPhoneNumber1.Name = "dgPhoneNumber1";
            this.dgPhoneNumber1.ReadOnly = true;
            // 
            // dgPhoneNumber2
            // 
            this.dgPhoneNumber2.HeaderText = "Phone Number 2";
            this.dgPhoneNumber2.Name = "dgPhoneNumber2";
            this.dgPhoneNumber2.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxClientSeach);
            this.Name = "FrmClients";
            this.Text = "FrmClients";
            this.grpbxClientSeach.ResumeLayout(false);
            this.grpbxClientSeach.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxClientSeach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClientNameSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtClientIdSearch;
        private System.Windows.Forms.Label lblClientNameSearch;
        private System.Windows.Forms.Label lblClientIdSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lblPhoneNumber2;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBoxMaritalStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.ComboBox comboBoxClientType;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.Label lblClienSurname;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtNationalIdNo;
        private System.Windows.Forms.Label lblNationalIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClientSuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNationalIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPassportNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMaritalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgJuristicRegistrationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgJuristicTaxNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgJuristicType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhoneNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhoneNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}