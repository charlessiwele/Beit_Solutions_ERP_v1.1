namespace Beit_Solutions_ERP_v1._1.Forms
{
    partial class FrmProducts
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
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblMinimumStock = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPorductCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.lblPurchaseRate = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblSalesRate = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblMaximumStock = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(118, 440);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(100, 33);
            this.btnRemoveProduct.TabIndex = 37;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(12, 440);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(100, 33);
            this.btnClearFields.TabIndex = 36;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(160, 19);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(206, 20);
            this.txtProductId.TabIndex = 35;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(51, 26);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(61, 13);
            this.lblProductId.TabIndex = 34;
            this.lblProductId.Text = "Product ID:";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(544, 440);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(100, 33);
            this.btnUpdateProduct.TabIndex = 33;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(650, 440);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 33);
            this.btnAddProduct.TabIndex = 32;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 440);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 33);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgDateModified
            // 
            this.dgDateModified.HeaderText = "Date Modified";
            this.dgDateModified.Name = "dgDateModified";
            this.dgDateModified.ReadOnly = true;
            // 
            // dgDateAdded
            // 
            this.dgDateAdded.HeaderText = "Date Added";
            this.dgDateAdded.Name = "dgDateAdded";
            this.dgDateAdded.ReadOnly = true;
            // 
            // dgProductPrice
            // 
            this.dgProductPrice.HeaderText = "Product Price";
            this.dgProductPrice.Name = "dgProductPrice";
            this.dgProductPrice.ReadOnly = true;
            // 
            // dgProductDescription
            // 
            this.dgProductDescription.HeaderText = "Product Description";
            this.dgProductDescription.Name = "dgProductDescription";
            this.dgProductDescription.ReadOnly = true;
            // 
            // dgProductType
            // 
            this.dgProductType.HeaderText = "Product Type";
            this.dgProductType.Name = "dgProductType";
            this.dgProductType.ReadOnly = true;
            // 
            // dgProductName
            // 
            this.dgProductName.HeaderText = "ProductName";
            this.dgProductName.Name = "dgProductName";
            this.dgProductName.ReadOnly = true;
            // 
            // dgProductId
            // 
            this.dgProductId.HeaderText = "Product ID";
            this.dgProductId.Name = "dgProductId";
            this.dgProductId.ReadOnly = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgProductId,
            this.dgProductName,
            this.dgProductType,
            this.dgProductDescription,
            this.dgProductPrice,
            this.dgDateAdded,
            this.dgDateModified});
            this.dgvProducts.Location = new System.Drawing.Point(12, 213);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(738, 221);
            this.dgvProducts.TabIndex = 30;
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Items.AddRange(new object[] {
            "",
            "Product",
            "Service"});
            this.comboBoxProductType.Location = new System.Drawing.Point(510, 148);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(206, 21);
            this.comboBoxProductType.TabIndex = 29;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(510, 19);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(206, 20);
            this.txtProductPrice.TabIndex = 28;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(160, 97);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(206, 20);
            this.txtProductDescription.TabIndex = 27;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(160, 45);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(206, 20);
            this.txtProductName.TabIndex = 26;
            // 
            // lblMinimumStock
            // 
            this.lblMinimumStock.AutoSize = true;
            this.lblMinimumStock.Location = new System.Drawing.Point(401, 26);
            this.lblMinimumStock.Name = "lblMinimumStock";
            this.lblMinimumStock.Size = new System.Drawing.Size(82, 13);
            this.lblMinimumStock.TabIndex = 25;
            this.lblMinimumStock.Text = "Minimum Stock:";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(51, 104);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(103, 13);
            this.lblProductDescription.TabIndex = 24;
            this.lblProductDescription.Text = "Product Description:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(401, 156);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 13);
            this.lblProductType.TabIndex = 23;
            this.lblProductType.Text = "Product Type:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPorductCode
            // 
            this.lblPorductCode.AutoSize = true;
            this.lblPorductCode.Location = new System.Drawing.Point(51, 51);
            this.lblPorductCode.Name = "lblPorductCode";
            this.lblPorductCode.Size = new System.Drawing.Size(75, 13);
            this.lblPorductCode.TabIndex = 22;
            this.lblPorductCode.Text = "Porduct Code:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 41;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(401, 78);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(77, 13);
            this.lblReorderLevel.TabIndex = 40;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // lblPurchaseRate
            // 
            this.lblPurchaseRate.AutoSize = true;
            this.lblPurchaseRate.Location = new System.Drawing.Point(51, 126);
            this.lblPurchaseRate.Name = "lblPurchaseRate";
            this.lblPurchaseRate.Size = new System.Drawing.Size(81, 13);
            this.lblPurchaseRate.TabIndex = 44;
            this.lblPurchaseRate.Text = "Purchase Rate:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(510, 97);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 46);
            this.textBox4.TabIndex = 43;
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.Location = new System.Drawing.Point(401, 104);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(53, 13);
            this.lblNarration.TabIndex = 42;
            this.lblNarration.Text = "Narration:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Product Name:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 20);
            this.textBox5.TabIndex = 50;
            // 
            // lblSalesRate
            // 
            this.lblSalesRate.AutoSize = true;
            this.lblSalesRate.Location = new System.Drawing.Point(51, 152);
            this.lblSalesRate.Name = "lblSalesRate";
            this.lblSalesRate.Size = new System.Drawing.Size(62, 13);
            this.lblSalesRate.TabIndex = 49;
            this.lblSalesRate.Text = "Sales Rate:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(510, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 20);
            this.textBox6.TabIndex = 52;
            // 
            // lblMaximumStock
            // 
            this.lblMaximumStock.AutoSize = true;
            this.lblMaximumStock.Location = new System.Drawing.Point(401, 52);
            this.lblMaximumStock.Name = "lblMaximumStock";
            this.lblMaximumStock.Size = new System.Drawing.Size(85, 13);
            this.lblMaximumStock.TabIndex = 51;
            this.lblMaximumStock.Text = "Maximum Stock:";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(404, 181);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(67, 17);
            this.checkBoxIsActive.TabIndex = 53;
            this.checkBoxIsActive.Text = "Is Active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 485);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblMaximumStock);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblSalesRate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPurchaseRate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblMinimumStock);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblPorductCode);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDateModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProductId;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblMinimumStock;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPorductCode;
        private System.Windows.Forms.Label lblPurchaseRate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblSalesRate;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblMaximumStock;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
    }
}