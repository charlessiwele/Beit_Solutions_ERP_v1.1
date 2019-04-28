namespace Beit_Solutions_ERP_v1._1.Forms
{
    partial class FrmBenefits
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBenefitName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDeductable = new System.Windows.Forms.Label();
            this.comboBoxDeductable = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCostToCompany = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblBenefitName
            // 
            this.lblBenefitName.AutoSize = true;
            this.lblBenefitName.Location = new System.Drawing.Point(12, 46);
            this.lblBenefitName.Name = "lblBenefitName";
            this.lblBenefitName.Size = new System.Drawing.Size(74, 13);
            this.lblBenefitName.TabIndex = 1;
            this.lblBenefitName.Text = "Benefit Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblDeductable
            // 
            this.lblDeductable.AutoSize = true;
            this.lblDeductable.Location = new System.Drawing.Point(12, 72);
            this.lblDeductable.Name = "lblDeductable";
            this.lblDeductable.Size = new System.Drawing.Size(65, 13);
            this.lblDeductable.TabIndex = 3;
            this.lblDeductable.Text = "Deductable:";
            // 
            // comboBoxDeductable
            // 
            this.comboBoxDeductable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeductable.FormattingEnabled = true;
            this.comboBoxDeductable.Location = new System.Drawing.Point(108, 63);
            this.comboBoxDeductable.Name = "comboBoxDeductable";
            this.comboBoxDeductable.Size = new System.Drawing.Size(156, 21);
            this.comboBoxDeductable.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblCostToCompany
            // 
            this.lblCostToCompany.AutoSize = true;
            this.lblCostToCompany.Location = new System.Drawing.Point(12, 97);
            this.lblCostToCompany.Name = "lblCostToCompany";
            this.lblCostToCompany.Size = new System.Drawing.Size(90, 13);
            this.lblCostToCompany.TabIndex = 5;
            this.lblCostToCompany.Text = "Cost to Company:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 116);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 58);
            this.textBox3.TabIndex = 8;
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.Location = new System.Drawing.Point(12, 123);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(53, 13);
            this.lblNarration.TabIndex = 7;
            this.lblNarration.Text = "Narration:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(201, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(294, 180);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(366, 179);
            this.dataGridView1.TabIndex = 12;
            // 
            // FrmBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCostToCompany);
            this.Controls.Add(this.comboBoxDeductable);
            this.Controls.Add(this.lblDeductable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBenefitName);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmBenefits";
            this.Text = "FrmBenefits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBenefitName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDeductable;
        private System.Windows.Forms.ComboBox comboBoxDeductable;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCostToCompany;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}