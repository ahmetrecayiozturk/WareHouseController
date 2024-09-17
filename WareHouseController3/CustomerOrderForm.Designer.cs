namespace WareHouseController3
{
    partial class CustomerOrderForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerContact = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.müsteriismi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgwSalesOrder = new System.Windows.Forms.DataGridView();
            this.salesQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.salesProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCustomerName = new System.Windows.Forms.TextBox();
            this.addCustomer = new System.Windows.Forms.Button();
            this.addCustomerOrder = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.searchCustomerName = new System.Windows.Forms.TextBox();
            this.showAllOrders = new System.Windows.Forms.Button();
            this.showUnpaidOrders = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.CheckBox();
            this.unpaid = new System.Windows.Forms.CheckBox();
            this.urunismi = new System.Windows.Forms.TextBox();
            this.paidAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.veresiyeode = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ispaid = new System.Windows.Forms.CheckBox();
            this.isunpaid = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.orderid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSalesOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "MÜŞTERİ İSMİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "MÜŞTERİ İLETİŞİM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "MÜŞTERİ ADRESİ";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(167, 140);
            this.customerName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(100, 22);
            this.customerName.TabIndex = 10;
            this.customerName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // customerContact
            // 
            this.customerContact.Location = new System.Drawing.Point(167, 44);
            this.customerContact.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.customerContact.Name = "customerContact";
            this.customerContact.Size = new System.Drawing.Size(100, 22);
            this.customerContact.TabIndex = 11;
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(167, 66);
            this.customerAddress.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(100, 22);
            this.customerAddress.TabIndex = 12;
            // 
            // müsteriismi
            // 
            this.müsteriismi.Location = new System.Drawing.Point(907, 429);
            this.müsteriismi.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.müsteriismi.Name = "müsteriismi";
            this.müsteriismi.Size = new System.Drawing.Size(150, 22);
            this.müsteriismi.TabIndex = 15;
            this.müsteriismi.TextChanged += new System.EventHandler(this.salesPaymentCondition_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 470);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ÜRÜN İSMİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "ALIŞ MİKTARI";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 236);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "ÖDENDİ Mİ";
            // 
            // dgwSalesOrder
            // 
            this.dgwSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSalesOrder.Location = new System.Drawing.Point(273, 47);
            this.dgwSalesOrder.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgwSalesOrder.Name = "dgwSalesOrder";
            this.dgwSalesOrder.RowHeadersWidth = 51;
            this.dgwSalesOrder.RowTemplate.Height = 24;
            this.dgwSalesOrder.Size = new System.Drawing.Size(1241, 343);
            this.dgwSalesOrder.TabIndex = 21;
            this.dgwSalesOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // salesQuantity
            // 
            this.salesQuantity.Location = new System.Drawing.Point(167, 199);
            this.salesQuantity.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.salesQuantity.Name = "salesQuantity";
            this.salesQuantity.Size = new System.Drawing.Size(100, 22);
            this.salesQuantity.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "ÜRÜN İSMİ";
            // 
            // salesProductName
            // 
            this.salesProductName.Location = new System.Drawing.Point(167, 170);
            this.salesProductName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.salesProductName.Name = "salesProductName";
            this.salesProductName.Size = new System.Drawing.Size(100, 22);
            this.salesProductName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "MÜŞTERİ İSMİ";
            // 
            // addCustomerName
            // 
            this.addCustomerName.Location = new System.Drawing.Point(167, 18);
            this.addCustomerName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.addCustomerName.Name = "addCustomerName";
            this.addCustomerName.Size = new System.Drawing.Size(100, 22);
            this.addCustomerName.TabIndex = 29;
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(27, 94);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(238, 38);
            this.addCustomer.TabIndex = 30;
            this.addCustomer.Text = "MÜŞTERİ EKLE";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // addCustomerOrder
            // 
            this.addCustomerOrder.Location = new System.Drawing.Point(27, 340);
            this.addCustomerOrder.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.addCustomerOrder.Name = "addCustomerOrder";
            this.addCustomerOrder.Size = new System.Drawing.Size(238, 50);
            this.addCustomerOrder.TabIndex = 31;
            this.addCustomerOrder.Text = "MÜŞTERİ EMRİ EKLE";
            this.addCustomerOrder.UseVisualStyleBackColor = true;
            this.addCustomerOrder.Click += new System.EventHandler(this.addCustomerOrder_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 593);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 44);
            this.button5.TabIndex = 34;
            this.button5.Text = "MÜŞTERİ EMRİNİ SİL";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searchCustomerName
            // 
            this.searchCustomerName.Location = new System.Drawing.Point(1326, 11);
            this.searchCustomerName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.searchCustomerName.Name = "searchCustomerName";
            this.searchCustomerName.Size = new System.Drawing.Size(188, 22);
            this.searchCustomerName.TabIndex = 39;
            this.searchCustomerName.TextChanged += new System.EventHandler(this.searchCustomerName_TextChanged);
            // 
            // showAllOrders
            // 
            this.showAllOrders.Location = new System.Drawing.Point(551, 2);
            this.showAllOrders.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.showAllOrders.Name = "showAllOrders";
            this.showAllOrders.Size = new System.Drawing.Size(272, 41);
            this.showAllOrders.TabIndex = 41;
            this.showAllOrders.Text = "TÜM ÜRÜNLERİ GÖSTER VEYA YENİLE";
            this.showAllOrders.UseVisualStyleBackColor = true;
            this.showAllOrders.Click += new System.EventHandler(this.showAllOrders_Click);
            // 
            // showUnpaidOrders
            // 
            this.showUnpaidOrders.Location = new System.Drawing.Point(273, 2);
            this.showUnpaidOrders.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.showUnpaidOrders.Name = "showUnpaidOrders";
            this.showUnpaidOrders.Size = new System.Drawing.Size(268, 41);
            this.showUnpaidOrders.TabIndex = 42;
            this.showUnpaidOrders.Text = "ÖDENMEMİŞ ÜRÜNLERİ GÖSTER";
            this.showUnpaidOrders.UseVisualStyleBackColor = true;
            this.showUnpaidOrders.Click += new System.EventHandler(this.showUnpaidOrders_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1166, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "MÜŞTERİ İSMİ İLE ARA";
            // 
            // paid
            // 
            this.paid.AutoSize = true;
            this.paid.Location = new System.Drawing.Point(167, 232);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(73, 20);
            this.paid.TabIndex = 44;
            this.paid.Text = "Ödendi";
            this.paid.UseVisualStyleBackColor = true;
            this.paid.CheckedChanged += new System.EventHandler(this.paid_CheckedChanged);
            // 
            // unpaid
            // 
            this.unpaid.AutoSize = true;
            this.unpaid.Location = new System.Drawing.Point(167, 258);
            this.unpaid.Name = "unpaid";
            this.unpaid.Size = new System.Drawing.Size(92, 20);
            this.unpaid.TabIndex = 46;
            this.unpaid.Text = "Ödenmedi";
            this.unpaid.UseVisualStyleBackColor = true;
            this.unpaid.CheckedChanged += new System.EventHandler(this.unpaid_CheckedChanged);
            // 
            // urunismi
            // 
            this.urunismi.Location = new System.Drawing.Point(907, 464);
            this.urunismi.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.urunismi.Name = "urunismi";
            this.urunismi.Size = new System.Drawing.Size(150, 22);
            this.urunismi.TabIndex = 47;
            // 
            // paidAmount
            // 
            this.paidAmount.Location = new System.Drawing.Point(907, 499);
            this.paidAmount.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.Size = new System.Drawing.Size(150, 22);
            this.paidAmount.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 435);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "MÜŞTERİ İSMİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 505);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "ÖDEME MİKTARI";
            // 
            // veresiyeode
            // 
            this.veresiyeode.Location = new System.Drawing.Point(692, 605);
            this.veresiyeode.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.veresiyeode.Name = "veresiyeode";
            this.veresiyeode.Size = new System.Drawing.Size(365, 50);
            this.veresiyeode.TabIndex = 53;
            this.veresiyeode.Text = "VERESİYE ÖDE";
            this.veresiyeode.UseVisualStyleBackColor = true;
            this.veresiyeode.Click += new System.EventHandler(this.veresiyeode_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(689, 544);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "ÖDENME DURUMU";
            // 
            // ispaid
            // 
            this.ispaid.AutoSize = true;
            this.ispaid.Location = new System.Drawing.Point(907, 540);
            this.ispaid.Name = "ispaid";
            this.ispaid.Size = new System.Drawing.Size(73, 20);
            this.ispaid.TabIndex = 55;
            this.ispaid.Text = "Ödendi";
            this.ispaid.UseVisualStyleBackColor = true;
            // 
            // isunpaid
            // 
            this.isunpaid.AutoSize = true;
            this.isunpaid.Location = new System.Drawing.Point(907, 570);
            this.isunpaid.Name = "isunpaid";
            this.isunpaid.Size = new System.Drawing.Size(92, 20);
            this.isunpaid.TabIndex = 56;
            this.isunpaid.Text = "Ödenmedi";
            this.isunpaid.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(689, 402);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 57;
            this.label12.Text = "EMİR NO\'SU";
            // 
            // orderid
            // 
            this.orderid.Location = new System.Drawing.Point(907, 394);
            this.orderid.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(150, 22);
            this.orderid.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(842, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 16);
            this.label14.TabIndex = 59;
            this.label14.Text = "EMİR NO İLE ARA";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(968, 11);
            this.idtext.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(188, 22);
            this.idtext.TabIndex = 60;
            this.idtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 688);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.orderid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.isunpaid);
            this.Controls.Add(this.ispaid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.veresiyeode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paidAmount);
            this.Controls.Add(this.urunismi);
            this.Controls.Add(this.unpaid);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showUnpaidOrders);
            this.Controls.Add(this.showAllOrders);
            this.Controls.Add(this.searchCustomerName);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.addCustomerOrder);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.addCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesProductName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.salesQuantity);
            this.Controls.Add(this.dgwSalesOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.müsteriismi);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerContact);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSalesOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox customerContact;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox müsteriismi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgwSalesOrder;
        private System.Windows.Forms.TextBox salesQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox salesProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addCustomerName;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button addCustomerOrder;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox searchCustomerName;
        private System.Windows.Forms.Button showAllOrders;
        private System.Windows.Forms.Button showUnpaidOrders;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox paid;
        private System.Windows.Forms.CheckBox unpaid;
        private System.Windows.Forms.TextBox urunismi;
        private System.Windows.Forms.TextBox paidAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button veresiyeode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ispaid;
        private System.Windows.Forms.CheckBox isunpaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox idtext;
    }
}