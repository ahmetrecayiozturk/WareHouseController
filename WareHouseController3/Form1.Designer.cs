namespace WareHouseController3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.addproduct = new System.Windows.Forms.Button();
            this.deleteproduct = new System.Windows.Forms.Button();
            this.updateproduct = new System.Windows.Forms.Button();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.searchproduct = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.unitprice = new System.Windows.Forms.MaskedTextBox();
            this.stockamount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryid = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minstock = new System.Windows.Forms.MaskedTextBox();
            this.maxstock = new System.Windows.Forms.MaskedTextBox();
            this.minprice = new System.Windows.Forms.MaskedTextBox();
            this.maxprice = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filterstockamount = new System.Windows.Forms.Button();
            this.filterunitprice = new System.Windows.Forms.Button();
            this.filtercategoryid = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryidvalue = new System.Windows.Forms.MaskedTextBox();
            this.customerorderbtn = new System.Windows.Forms.Button();
            this.supplierorderbtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(49, 474);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(131, 36);
            this.addproduct.TabIndex = 3;
            this.addproduct.Text = "add";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // deleteproduct
            // 
            this.deleteproduct.Location = new System.Drawing.Point(434, 474);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(128, 36);
            this.deleteproduct.TabIndex = 4;
            this.deleteproduct.Text = "delete";
            this.deleteproduct.UseVisualStyleBackColor = true;
            this.deleteproduct.Click += new System.EventHandler(this.deleteproduct_Click);
            // 
            // updateproduct
            // 
            this.updateproduct.Location = new System.Drawing.Point(248, 474);
            this.updateproduct.Name = "updateproduct";
            this.updateproduct.Size = new System.Drawing.Size(128, 36);
            this.updateproduct.TabIndex = 5;
            this.updateproduct.Text = "update";
            this.updateproduct.UseVisualStyleBackColor = true;
            this.updateproduct.Click += new System.EventHandler(this.updateproduct_Click);
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(49, 41);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.Size = new System.Drawing.Size(607, 237);
            this.dgw.TabIndex = 6;
            this.dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellContentClick);
            // 
            // searchproduct
            // 
            this.searchproduct.Location = new System.Drawing.Point(495, 12);
            this.searchproduct.Name = "searchproduct";
            this.searchproduct.Size = new System.Drawing.Size(127, 23);
            this.searchproduct.TabIndex = 7;
            this.searchproduct.Text = "search";
            this.searchproduct.UseVisualStyleBackColor = true;
            this.searchproduct.Click += new System.EventHandler(this.searchproduct_Click);
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(662, 13);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(256, 22);
            this.searchtext.TabIndex = 8;
            this.searchtext.TextChanged += new System.EventHandler(this.searchtext_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(445, 295);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 9;
            // 
            // unitprice
            // 
            this.unitprice.Location = new System.Drawing.Point(445, 335);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(100, 22);
            this.unitprice.TabIndex = 10;
            // 
            // stockamount
            // 
            this.stockamount.Location = new System.Drawing.Point(445, 383);
            this.stockamount.Name = "stockamount";
            this.stockamount.Size = new System.Drawing.Size(100, 22);
            this.stockamount.TabIndex = 11;
            this.stockamount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.stockamount_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "stock amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "unit price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // categoryid
            // 
            this.categoryid.Location = new System.Drawing.Point(445, 433);
            this.categoryid.Name = "categoryid";
            this.categoryid.Size = new System.Drawing.Size(100, 22);
            this.categoryid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "category id";
            // 
            // minstock
            // 
            this.minstock.Location = new System.Drawing.Point(784, 114);
            this.minstock.Name = "minstock";
            this.minstock.Size = new System.Drawing.Size(49, 22);
            this.minstock.TabIndex = 18;
            // 
            // maxstock
            // 
            this.maxstock.Location = new System.Drawing.Point(860, 114);
            this.maxstock.Name = "maxstock";
            this.maxstock.Size = new System.Drawing.Size(49, 22);
            this.maxstock.TabIndex = 20;
            this.maxstock.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // minprice
            // 
            this.minprice.Location = new System.Drawing.Point(784, 161);
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(49, 22);
            this.minprice.TabIndex = 21;
            // 
            // maxprice
            // 
            this.maxprice.Location = new System.Drawing.Point(860, 161);
            this.maxprice.Name = "maxprice";
            this.maxprice.Size = new System.Drawing.Size(49, 22);
            this.maxprice.TabIndex = 22;
            this.maxprice.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Min";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // filterstockamount
            // 
            this.filterstockamount.Location = new System.Drawing.Point(767, 253);
            this.filterstockamount.Name = "filterstockamount";
            this.filterstockamount.Size = new System.Drawing.Size(142, 36);
            this.filterstockamount.TabIndex = 51;
            this.filterstockamount.Text = "FilterByStockAmount";
            this.filterstockamount.UseVisualStyleBackColor = true;
            this.filterstockamount.Click += new System.EventHandler(this.filterstockamount_Click);
            // 
            // filterunitprice
            // 
            this.filterunitprice.Location = new System.Drawing.Point(767, 295);
            this.filterunitprice.Name = "filterunitprice";
            this.filterunitprice.Size = new System.Drawing.Size(142, 36);
            this.filterunitprice.TabIndex = 52;
            this.filterunitprice.Text = "FilterByUnitPrice";
            this.filterunitprice.UseVisualStyleBackColor = true;
            this.filterunitprice.Click += new System.EventHandler(this.filterunitprice_Click);
            // 
            // filtercategoryid
            // 
            this.filtercategoryid.Location = new System.Drawing.Point(767, 341);
            this.filtercategoryid.Name = "filtercategoryid";
            this.filtercategoryid.Size = new System.Drawing.Size(142, 36);
            this.filtercategoryid.TabIndex = 53;
            this.filtercategoryid.Text = "FilterByCategoryId";
            this.filtercategoryid.UseVisualStyleBackColor = true;
            this.filtercategoryid.Click += new System.EventHandler(this.filtercategoryid_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "UnitPrice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "StockAmount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 213);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "CategoryId";
            // 
            // categoryidvalue
            // 
            this.categoryidvalue.Location = new System.Drawing.Point(784, 210);
            this.categoryidvalue.Name = "categoryidvalue";
            this.categoryidvalue.Size = new System.Drawing.Size(134, 22);
            this.categoryidvalue.TabIndex = 57;
            this.categoryidvalue.Text = " ";
            // 
            // customerorderbtn
            // 
            this.customerorderbtn.Location = new System.Drawing.Point(871, 474);
            this.customerorderbtn.Name = "customerorderbtn";
            this.customerorderbtn.Size = new System.Drawing.Size(128, 36);
            this.customerorderbtn.TabIndex = 58;
            this.customerorderbtn.Text = "CustomerOrder";
            this.customerorderbtn.UseVisualStyleBackColor = true;
            this.customerorderbtn.Click += new System.EventHandler(this.customerorderbtn_Click);
            // 
            // supplierorderbtn
            // 
            this.supplierorderbtn.Location = new System.Drawing.Point(662, 474);
            this.supplierorderbtn.Name = "supplierorderbtn";
            this.supplierorderbtn.Size = new System.Drawing.Size(128, 36);
            this.supplierorderbtn.TabIndex = 59;
            this.supplierorderbtn.Text = "Supplier Order";
            this.supplierorderbtn.UseVisualStyleBackColor = true;
            this.supplierorderbtn.Click += new System.EventHandler(this.supplierorderbtn_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(49, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(120, 32);
            this.refresh.TabIndex = 60;
            this.refresh.Text = "Refresh Products";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(248, 5);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(142, 36);
            this.showAll.TabIndex = 61;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 566);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.supplierorderbtn);
            this.Controls.Add(this.customerorderbtn);
            this.Controls.Add(this.categoryidvalue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filtercategoryid);
            this.Controls.Add(this.filterunitprice);
            this.Controls.Add(this.filterstockamount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxprice);
            this.Controls.Add(this.minprice);
            this.Controls.Add(this.maxstock);
            this.Controls.Add(this.minstock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockamount);
            this.Controls.Add(this.unitprice);
            this.Controls.Add(this.name);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.searchproduct);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.updateproduct);
            this.Controls.Add(this.deleteproduct);
            this.Controls.Add(this.addproduct);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Button deleteproduct;
        private System.Windows.Forms.Button updateproduct;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button searchproduct;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox unitprice;
        private System.Windows.Forms.MaskedTextBox stockamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox categoryid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox minstock;
        private System.Windows.Forms.MaskedTextBox maxstock;
        private System.Windows.Forms.MaskedTextBox minprice;
        private System.Windows.Forms.MaskedTextBox maxprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filterstockamount;
        private System.Windows.Forms.Button filterunitprice;
        private System.Windows.Forms.Button filtercategoryid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox categoryidvalue;
        private System.Windows.Forms.Button customerorderbtn;
        private System.Windows.Forms.Button supplierorderbtn;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button showAll;
    }
}

