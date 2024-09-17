namespace WareHouseController3
{
    partial class Suppliers
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
            this.addSupplierName = new System.Windows.Forms.TextBox();
            this.addAddress = new System.Windows.Forms.TextBox();
            this.addContact = new System.Windows.Forms.TextBox();
            this.SupplierName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addSupplierbtn = new System.Windows.Forms.Button();
            this.deleteSupplierbtn = new System.Windows.Forms.Button();
            this.searchSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 490);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addSupplierName
            // 
            this.addSupplierName.Location = new System.Drawing.Point(208, 77);
            this.addSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.addSupplierName.Name = "addSupplierName";
            this.addSupplierName.Size = new System.Drawing.Size(100, 22);
            this.addSupplierName.TabIndex = 2;
            this.addSupplierName.TextChanged += new System.EventHandler(this.addSupplierName_TextChanged);
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(208, 122);
            this.addAddress.Margin = new System.Windows.Forms.Padding(2);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(100, 22);
            this.addAddress.TabIndex = 5;
            // 
            // addContact
            // 
            this.addContact.Location = new System.Drawing.Point(208, 164);
            this.addContact.Margin = new System.Windows.Forms.Padding(2);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(100, 22);
            this.addContact.TabIndex = 6;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSize = true;
            this.SupplierName.Location = new System.Drawing.Point(13, 84);
            this.SupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(106, 16);
            this.SupplierName.TabIndex = 7;
            this.SupplierName.Text = "TEDARİKÇİ İSMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TEDARİKÇİ ADRESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "TEDARİKÇİ İLETİŞİM";
            // 
            // addSupplierbtn
            // 
            this.addSupplierbtn.Location = new System.Drawing.Point(15, 293);
            this.addSupplierbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addSupplierbtn.Name = "addSupplierbtn";
            this.addSupplierbtn.Size = new System.Drawing.Size(295, 50);
            this.addSupplierbtn.TabIndex = 37;
            this.addSupplierbtn.Text = "TEDARİKÇİ EKLE";
            this.addSupplierbtn.UseVisualStyleBackColor = true;
            this.addSupplierbtn.Click += new System.EventHandler(this.addSupplierbtn_Click);
            // 
            // deleteSupplierbtn
            // 
            this.deleteSupplierbtn.Location = new System.Drawing.Point(16, 494);
            this.deleteSupplierbtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSupplierbtn.Name = "deleteSupplierbtn";
            this.deleteSupplierbtn.Size = new System.Drawing.Size(294, 50);
            this.deleteSupplierbtn.TabIndex = 38;
            this.deleteSupplierbtn.Text = "TEDARİKÇİ SİL";
            this.deleteSupplierbtn.UseVisualStyleBackColor = true;
            this.deleteSupplierbtn.Click += new System.EventHandler(this.deleteSupplierbtn_Click);
            // 
            // searchSupplier
            // 
            this.searchSupplier.Location = new System.Drawing.Point(889, 16);
            this.searchSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.searchSupplier.Name = "searchSupplier";
            this.searchSupplier.Size = new System.Drawing.Size(270, 22);
            this.searchSupplier.TabIndex = 39;
            this.searchSupplier.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "TEDARİKÇİ İSMİ İLE ARA";
            // 
            // refreshData
            // 
            this.refreshData.Location = new System.Drawing.Point(11, 5);
            this.refreshData.Margin = new System.Windows.Forms.Padding(2);
            this.refreshData.Name = "refreshData";
            this.refreshData.Size = new System.Drawing.Size(297, 50);
            this.refreshData.TabIndex = 46;
            this.refreshData.Text = "TEDARİKÇİLERİ YENİLE";
            this.refreshData.UseVisualStyleBackColor = true;
            this.refreshData.Click += new System.EventHandler(this.refreshData_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 590);
            this.Controls.Add(this.refreshData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchSupplier);
            this.Controls.Add(this.deleteSupplierbtn);
            this.Controls.Add(this.addSupplierbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupplierName);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.addSupplierName);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox addSupplierName;
        private System.Windows.Forms.TextBox addAddress;
        private System.Windows.Forms.TextBox addContact;
        private System.Windows.Forms.Label SupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addSupplierbtn;
        private System.Windows.Forms.Button deleteSupplierbtn;
        private System.Windows.Forms.TextBox searchSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshData;
    }
}