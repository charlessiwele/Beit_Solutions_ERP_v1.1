namespace Beit_Solutions_ERP_v1._1.Forms
{
    partial class FrmSalesInvoices
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.cbxApproved = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbPricinglevel = new System.Windows.Forms.ComboBox();
            this.lblPricingLevel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbSalesman = new System.Windows.Forms.ComboBox();
            this.lblSalesMan = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashParty = new System.Windows.Forms.Label();
            this.txtQuotationNo = new System.Windows.Forms.TextBox();
            this.lblSalesQuotationNo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(525, 418);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 1186;
            this.label11.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(590, 411);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(169, 20);
            this.txtTotal.TabIndex = 1184;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(590, 356);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(169, 50);
            this.txtNarration.TabIndex = 1183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(525, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1185;
            this.label1.Text = "Narration";
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(61, 376);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 1182;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            // 
            // cbxApproved
            // 
            this.cbxApproved.AutoSize = true;
            this.cbxApproved.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxApproved.Location = new System.Drawing.Point(61, 358);
            this.cbxApproved.Name = "cbxApproved";
            this.cbxApproved.Size = new System.Drawing.Size(72, 17);
            this.cbxApproved.TabIndex = 1181;
            this.cbxApproved.Text = "Approved";
            this.cbxApproved.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 168);
            this.dataGridView1.TabIndex = 1179;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(559, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1178;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(559, 93);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(200, 21);
            this.cmbCurrency.TabIndex = 1174;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency.Location = new System.Drawing.Point(467, 101);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 1177;
            this.lblCurrency.Text = "Currency";
            // 
            // cmbPricinglevel
            // 
            this.cmbPricinglevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricinglevel.FormattingEnabled = true;
            this.cmbPricinglevel.Location = new System.Drawing.Point(559, 67);
            this.cmbPricinglevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbPricinglevel.Name = "cmbPricinglevel";
            this.cmbPricinglevel.Size = new System.Drawing.Size(200, 21);
            this.cmbPricinglevel.TabIndex = 1173;
            // 
            // lblPricingLevel
            // 
            this.lblPricingLevel.AutoSize = true;
            this.lblPricingLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPricingLevel.Location = new System.Drawing.Point(467, 75);
            this.lblPricingLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPricingLevel.Name = "lblPricingLevel";
            this.lblPricingLevel.Size = new System.Drawing.Size(68, 13);
            this.lblPricingLevel.TabIndex = 1176;
            this.lblPricingLevel.Text = "Pricing Level";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(467, 45);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1175;
            this.lblDate.Text = "Date";
            // 
            // cmbSalesman
            // 
            this.cmbSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesman.FormattingEnabled = true;
            this.cmbSalesman.Location = new System.Drawing.Point(153, 93);
            this.cmbSalesman.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesman.Name = "cmbSalesman";
            this.cmbSalesman.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesman.TabIndex = 1169;
            // 
            // lblSalesMan
            // 
            this.lblSalesMan.AutoSize = true;
            this.lblSalesMan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesMan.Location = new System.Drawing.Point(58, 101);
            this.lblSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesMan.Name = "lblSalesMan";
            this.lblSalesMan.Size = new System.Drawing.Size(57, 13);
            this.lblSalesMan.TabIndex = 1172;
            this.lblSalesMan.Text = "Sales Man";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(153, 67);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 1168;
            // 
            // lblCashParty
            // 
            this.lblCashParty.AutoSize = true;
            this.lblCashParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashParty.Location = new System.Drawing.Point(58, 75);
            this.lblCashParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashParty.Name = "lblCashParty";
            this.lblCashParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashParty.TabIndex = 1171;
            this.lblCashParty.Text = "Cash / Party";
            // 
            // txtQuotationNo
            // 
            this.txtQuotationNo.Location = new System.Drawing.Point(153, 42);
            this.txtQuotationNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtQuotationNo.Name = "txtQuotationNo";
            this.txtQuotationNo.Size = new System.Drawing.Size(200, 20);
            this.txtQuotationNo.TabIndex = 1167;
            // 
            // lblSalesQuotationNo
            // 
            this.lblSalesQuotationNo.AutoSize = true;
            this.lblSalesQuotationNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesQuotationNo.Location = new System.Drawing.Point(58, 49);
            this.lblSalesQuotationNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesQuotationNo.Name = "lblSalesQuotationNo";
            this.lblSalesQuotationNo.Size = new System.Drawing.Size(62, 13);
            this.lblSalesQuotationNo.TabIndex = 1170;
            this.lblSalesQuotationNo.Text = "Invoice No.";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 119);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1191;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1192;
            this.label2.Text = "Sale Against";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Location = new System.Drawing.Point(152, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 27);
            this.btnUpdate.TabIndex = 1195;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(61, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 1194;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(243, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 27);
            this.button2.TabIndex = 1193;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Location = new System.Drawing.Point(581, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1196;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(672, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 1197;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 1198;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1199;
            this.label3.Text = "Client Id.";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearchClient.FlatAppearance.BorderSize = 0;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearchClient.Location = new System.Drawing.Point(294, 145);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(59, 20);
            this.btnSearchClient.TabIndex = 1200;
            this.btnSearchClient.Text = "Search";
            this.btnSearchClient.UseVisualStyleBackColor = false;
            // 
            // FrmSalesInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 476);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.cbxApproved);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cmbPricinglevel);
            this.Controls.Add(this.lblPricingLevel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbSalesman);
            this.Controls.Add(this.lblSalesMan);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashParty);
            this.Controls.Add(this.txtQuotationNo);
            this.Controls.Add(this.lblSalesQuotationNo);
            this.Name = "FrmSalesInvoices";
            this.Text = "FrmSalesQuote";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.CheckBox cbxApproved;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cmbPricinglevel;
        private System.Windows.Forms.Label lblPricingLevel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbSalesman;
        private System.Windows.Forms.Label lblSalesMan;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashParty;
        private System.Windows.Forms.TextBox txtQuotationNo;
        private System.Windows.Forms.Label lblSalesQuotationNo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchClient;
    }
}