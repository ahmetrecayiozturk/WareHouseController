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
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(49, 426);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(127, 23);
            this.addproduct.TabIndex = 3;
            this.addproduct.Text = "add";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // deleteproduct
            // 
            this.deleteproduct.Location = new System.Drawing.Point(716, 426);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(127, 23);
            this.deleteproduct.TabIndex = 4;
            this.deleteproduct.Text = "delete";
            this.deleteproduct.UseVisualStyleBackColor = true;
            this.deleteproduct.Click += new System.EventHandler(this.deleteproduct_Click);
            // 
            // updateproduct
            // 
            this.updateproduct.Location = new System.Drawing.Point(378, 426);
            this.updateproduct.Name = "updateproduct";
            this.updateproduct.Size = new System.Drawing.Size(127, 23);
            this.updateproduct.TabIndex = 5;
            this.updateproduct.Text = "update";
            this.updateproduct.UseVisualStyleBackColor = true;
            this.updateproduct.Click += new System.EventHandler(this.updateproduct_Click);
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(49, 52);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.Size = new System.Drawing.Size(439, 228);
            this.dgw.TabIndex = 6;
            this.dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellContentClick);
            // 
            // searchproduct
            // 
            this.searchproduct.Location = new System.Drawing.Point(361, 26);
            this.searchproduct.Name = "searchproduct";
            this.searchproduct.Size = new System.Drawing.Size(127, 23);
            this.searchproduct.TabIndex = 7;
            this.searchproduct.Text = "search";
            this.searchproduct.UseVisualStyleBackColor = true;
            this.searchproduct.Click += new System.EventHandler(this.searchproduct_Click);
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(536, 29);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(256, 22);
            this.searchtext.TabIndex = 8;
            this.searchtext.TextChanged += new System.EventHandler(this.searchtext_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(388, 286);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 9;
            // 
            // unitprice
            // 
            this.unitprice.Location = new System.Drawing.Point(388, 335);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(100, 22);
            this.unitprice.TabIndex = 10;
            // 
            // stockamount
            // 
            this.stockamount.Location = new System.Drawing.Point(388, 383);
            this.stockamount.Name = "stockamount";
            this.stockamount.Size = new System.Drawing.Size(100, 22);
            this.stockamount.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "stock amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "unit price";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(932, 509);
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
    }
}

