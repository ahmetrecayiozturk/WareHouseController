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
            this.searchtext = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.unitprice = new System.Windows.Forms.MaskedTextBox();
            this.stockamount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minstock = new System.Windows.Forms.MaskedTextBox();
            this.maxstock = new System.Windows.Forms.MaskedTextBox();
            this.minprice = new System.Windows.Forms.MaskedTextBox();
            this.maxprice = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filterstockamount = new System.Windows.Forms.Button();
            this.filterunitprice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerorderbtn = new System.Windows.Forms.Button();
            this.supplierorderbtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.showCustomers = new System.Windows.Forms.Button();
            this.showSuppliers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.showAllProfitDaily = new System.Windows.Forms.Button();
            this.showProfitMonthly = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.purchasePrice = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(49, 527);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(142, 36);
            this.addproduct.TabIndex = 3;
            this.addproduct.Text = "ÜRÜNÜ EKLE";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // deleteproduct
            // 
            this.deleteproduct.Location = new System.Drawing.Point(445, 527);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(142, 36);
            this.deleteproduct.TabIndex = 4;
            this.deleteproduct.Text = "ÜRÜNÜ SİL";
            this.deleteproduct.UseVisualStyleBackColor = true;
            this.deleteproduct.Click += new System.EventHandler(this.deleteproduct_Click);
            // 
            // updateproduct
            // 
            this.updateproduct.Location = new System.Drawing.Point(248, 527);
            this.updateproduct.Name = "updateproduct";
            this.updateproduct.Size = new System.Drawing.Size(142, 36);
            this.updateproduct.TabIndex = 5;
            this.updateproduct.Text = "ÜRÜNÜ GÜNCELLE";
            this.updateproduct.UseVisualStyleBackColor = true;
            this.updateproduct.Click += new System.EventHandler(this.updateproduct_Click);
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(22, 49);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.Size = new System.Drawing.Size(733, 278);
            this.dgw.TabIndex = 6;
            this.dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellContentClick);
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(784, 9);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(256, 22);
            this.searchtext.TabIndex = 8;
            this.searchtext.TextChanged += new System.EventHandler(this.searchtext_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(445, 336);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 9;
            // 
            // unitprice
            // 
            this.unitprice.Location = new System.Drawing.Point(445, 379);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(100, 22);
            this.unitprice.TabIndex = 10;
            // 
            // stockamount
            // 
            this.stockamount.Location = new System.Drawing.Point(445, 454);
            this.stockamount.Name = "stockamount";
            this.stockamount.Size = new System.Drawing.Size(100, 22);
            this.stockamount.TabIndex = 11;
            this.stockamount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.stockamount_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ÜRÜN İSMİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "STOK MİKTARI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ÜRÜN FİYATI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // minstock
            // 
            this.minstock.Location = new System.Drawing.Point(866, 111);
            this.minstock.Name = "minstock";
            this.minstock.Size = new System.Drawing.Size(49, 22);
            this.minstock.TabIndex = 18;
            // 
            // maxstock
            // 
            this.maxstock.Location = new System.Drawing.Point(921, 110);
            this.maxstock.Name = "maxstock";
            this.maxstock.Size = new System.Drawing.Size(49, 22);
            this.maxstock.TabIndex = 20;
            this.maxstock.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // minprice
            // 
            this.minprice.Location = new System.Drawing.Point(866, 192);
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(49, 22);
            this.minprice.TabIndex = 21;
            // 
            // maxprice
            // 
            this.maxprice.Location = new System.Drawing.Point(921, 192);
            this.maxprice.Name = "maxprice";
            this.maxprice.Size = new System.Drawing.Size(49, 22);
            this.maxprice.TabIndex = 22;
            this.maxprice.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(937, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "MAX";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(872, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "MİN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // filterstockamount
            // 
            this.filterstockamount.Location = new System.Drawing.Point(997, 110);
            this.filterstockamount.Name = "filterstockamount";
            this.filterstockamount.Size = new System.Drawing.Size(227, 36);
            this.filterstockamount.TabIndex = 51;
            this.filterstockamount.Text = "MİKTARA GÖRE FİLTRELE";
            this.filterstockamount.UseVisualStyleBackColor = true;
            this.filterstockamount.Click += new System.EventHandler(this.filterstockamount_Click);
            // 
            // filterunitprice
            // 
            this.filterunitprice.Location = new System.Drawing.Point(997, 178);
            this.filterunitprice.Name = "filterunitprice";
            this.filterunitprice.Size = new System.Drawing.Size(227, 36);
            this.filterunitprice.TabIndex = 52;
            this.filterunitprice.Text = "ÜRÜN FİYATINA GÖRE FİLTRELE";
            this.filterunitprice.UseVisualStyleBackColor = true;
            this.filterunitprice.Click += new System.EventHandler(this.filterunitprice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "ÜRÜN FİYATI";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(761, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "STOK MİKTARI";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // customerorderbtn
            // 
            this.customerorderbtn.Location = new System.Drawing.Point(1031, 415);
            this.customerorderbtn.Name = "customerorderbtn";
            this.customerorderbtn.Size = new System.Drawing.Size(173, 36);
            this.customerorderbtn.TabIndex = 58;
            this.customerorderbtn.Text = "MÜŞTERİ EMRİ OLUŞTUR";
            this.customerorderbtn.UseVisualStyleBackColor = true;
            this.customerorderbtn.Click += new System.EventHandler(this.customerorderbtn_Click);
            // 
            // supplierorderbtn
            // 
            this.supplierorderbtn.Location = new System.Drawing.Point(784, 415);
            this.supplierorderbtn.Name = "supplierorderbtn";
            this.supplierorderbtn.Size = new System.Drawing.Size(173, 36);
            this.supplierorderbtn.TabIndex = 59;
            this.supplierorderbtn.Text = "TEDARİKÇİ EMRİ OLUŞTUR";
            this.supplierorderbtn.UseVisualStyleBackColor = true;
            this.supplierorderbtn.Click += new System.EventHandler(this.supplierorderbtn_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(22, 7);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(187, 32);
            this.refresh.TabIndex = 60;
            this.refresh.Text = "ÜRÜNLERİ YENİLE";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(295, 7);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(187, 36);
            this.showAll.TabIndex = 61;
            this.showAll.Text = "TÜM ÜRÜNLERİ GÖSTER";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // showCustomers
            // 
            this.showCustomers.Location = new System.Drawing.Point(1031, 497);
            this.showCustomers.Name = "showCustomers";
            this.showCustomers.Size = new System.Drawing.Size(173, 36);
            this.showCustomers.TabIndex = 62;
            this.showCustomers.Text = "MÜŞTERİLER";
            this.showCustomers.UseVisualStyleBackColor = true;
            this.showCustomers.Click += new System.EventHandler(this.showCustomers_Click);
            // 
            // showSuppliers
            // 
            this.showSuppliers.Location = new System.Drawing.Point(784, 497);
            this.showSuppliers.Name = "showSuppliers";
            this.showSuppliers.Size = new System.Drawing.Size(173, 36);
            this.showSuppliers.TabIndex = 63;
            this.showSuppliers.Text = "TEDARİKÇİLER";
            this.showSuppliers.UseVisualStyleBackColor = true;
            this.showSuppliers.Click += new System.EventHandler(this.showSuppliers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "ÜRÜN İSMİYLE ARA";
            // 
            // showAllProfitDaily
            // 
            this.showAllProfitDaily.Location = new System.Drawing.Point(784, 294);
            this.showAllProfitDaily.Name = "showAllProfitDaily";
            this.showAllProfitDaily.Size = new System.Drawing.Size(173, 64);
            this.showAllProfitDaily.TabIndex = 66;
            this.showAllProfitDaily.Text = "GÜNLÜK KARI GÖSTER";
            this.showAllProfitDaily.UseVisualStyleBackColor = true;
            this.showAllProfitDaily.Click += new System.EventHandler(this.showAllProfitDaily_Click);
            // 
            // showProfitMonthly
            // 
            this.showProfitMonthly.Location = new System.Drawing.Point(1031, 294);
            this.showProfitMonthly.Name = "showProfitMonthly";
            this.showProfitMonthly.Size = new System.Drawing.Size(173, 64);
            this.showProfitMonthly.TabIndex = 67;
            this.showProfitMonthly.Text = "AYLIK KARI GÖSTER";
            this.showProfitMonthly.UseVisualStyleBackColor = true;
            this.showProfitMonthly.Click += new System.EventHandler(this.showProfitMonthly_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "ALIŞ FİYATI";
            // 
            // purchasePrice
            // 
            this.purchasePrice.Location = new System.Drawing.Point(445, 419);
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Size = new System.Drawing.Size(100, 22);
            this.purchasePrice.TabIndex = 69;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1236, 620);
            this.Controls.Add(this.purchasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showProfitMonthly);
            this.Controls.Add(this.showAllProfitDaily);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.showSuppliers);
            this.Controls.Add(this.showCustomers);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.supplierorderbtn);
            this.Controls.Add(this.customerorderbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filterunitprice);
            this.Controls.Add(this.filterstockamount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxprice);
            this.Controls.Add(this.minprice);
            this.Controls.Add(this.maxstock);
            this.Controls.Add(this.minstock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockamount);
            this.Controls.Add(this.unitprice);
            this.Controls.Add(this.name);
            this.Controls.Add(this.searchtext);
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
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox unitprice;
        private System.Windows.Forms.MaskedTextBox stockamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox minstock;
        private System.Windows.Forms.MaskedTextBox maxstock;
        private System.Windows.Forms.MaskedTextBox minprice;
        private System.Windows.Forms.MaskedTextBox maxprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filterstockamount;
        private System.Windows.Forms.Button filterunitprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button customerorderbtn;
        private System.Windows.Forms.Button supplierorderbtn;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Button showCustomers;
        private System.Windows.Forms.Button showSuppliers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button showAllProfitDaily;
        private System.Windows.Forms.Button showProfitMonthly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox purchasePrice;
    }
}

