namespace WareHouseController3
{
    partial class Customers
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
            this.label3 = new System.Windows.Forms.Label();
            this.addCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAddress = new System.Windows.Forms.TextBox();
            this.addContact = new System.Windows.Forms.TextBox();
            this.addSupplierbtn = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.searchCustomer = new System.Windows.Forms.TextBox();
            this.refreshData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "MÜŞTERİ İSMİ";
            // 
            // addCustomerName
            // 
            this.addCustomerName.Location = new System.Drawing.Point(230, 86);
            this.addCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomerName.Name = "addCustomerName";
            this.addCustomerName.Size = new System.Drawing.Size(100, 22);
            this.addCustomerName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "MÜŞTERİ ADRESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "MÜŞTERİ İLETİŞİM";
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(230, 132);
            this.addAddress.Margin = new System.Windows.Forms.Padding(2);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(100, 22);
            this.addAddress.TabIndex = 12;
            // 
            // addContact
            // 
            this.addContact.Location = new System.Drawing.Point(230, 190);
            this.addContact.Margin = new System.Windows.Forms.Padding(2);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(100, 22);
            this.addContact.TabIndex = 13;
            // 
            // addSupplierbtn
            // 
            this.addSupplierbtn.Location = new System.Drawing.Point(33, 338);
            this.addSupplierbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addSupplierbtn.Name = "addSupplierbtn";
            this.addSupplierbtn.Size = new System.Drawing.Size(297, 50);
            this.addSupplierbtn.TabIndex = 38;
            this.addSupplierbtn.Text = "MÜŞTERİ EKLE";
            this.addSupplierbtn.UseVisualStyleBackColor = true;
            this.addSupplierbtn.Click += new System.EventHandler(this.addSupplierbtn_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(33, 518);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(297, 50);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "MÜŞTERİYİ SİL";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(822, 482);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "MÜŞTERİ İSMİ İLE ARA";
            // 
            // searchCustomer
            // 
            this.searchCustomer.Location = new System.Drawing.Point(962, 42);
            this.searchCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.Size = new System.Drawing.Size(270, 22);
            this.searchCustomer.TabIndex = 44;
            this.searchCustomer.TextChanged += new System.EventHandler(this.searchSupplier_TextChanged);
            // 
            // refreshData
            // 
            this.refreshData.Location = new System.Drawing.Point(33, 11);
            this.refreshData.Margin = new System.Windows.Forms.Padding(2);
            this.refreshData.Name = "refreshData";
            this.refreshData.Size = new System.Drawing.Size(297, 50);
            this.refreshData.TabIndex = 45;
            this.refreshData.Text = "MÜŞTERİ YENİLE";
            this.refreshData.UseVisualStyleBackColor = true;
            this.refreshData.Click += new System.EventHandler(this.refreshData_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 613);
            this.Controls.Add(this.refreshData);
            this.Controls.Add(this.searchCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addSupplierbtn);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCustomerName);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addAddress;
        private System.Windows.Forms.TextBox addContact;
        private System.Windows.Forms.Button addSupplierbtn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchCustomer;
        private System.Windows.Forms.Button refreshData;
    }
}