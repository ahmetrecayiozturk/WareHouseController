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
            this.salesPaymentCondition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgwSalesOrder = new System.Windows.Forms.DataGridView();
            this.salesQuantity = new System.Windows.Forms.TextBox();
            this.salesOrderDate = new System.Windows.Forms.TextBox();
            this.salesCondition = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.salesProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCustomerName = new System.Windows.Forms.TextBox();
            this.addCustomer = new System.Windows.Forms.Button();
            this.addCustomerOrder = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.orderConfirmText = new System.Windows.Forms.TextBox();
            this.confirmOrderBtn = new System.Windows.Forms.Button();
            this.confirmBackConditionBtn = new System.Windows.Forms.Button();
            this.confirmBackCondition = new System.Windows.Forms.TextBox();
            this.searchCustomerName = new System.Windows.Forms.TextBox();
            this.showAllOrders = new System.Windows.Forms.Button();
            this.showUnpaidOrders = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSalesOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CustomerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "CustomerContactInfo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "CustomerAddress";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(146, 140);
            this.customerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(88, 24);
            this.customerName.TabIndex = 10;
            this.customerName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // customerContact
            // 
            this.customerContact.Location = new System.Drawing.Point(146, 44);
            this.customerContact.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.customerContact.Name = "customerContact";
            this.customerContact.Size = new System.Drawing.Size(88, 24);
            this.customerContact.TabIndex = 11;
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(146, 66);
            this.customerAddress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(88, 24);
            this.customerAddress.TabIndex = 12;
            // 
            // salesPaymentCondition
            // 
            this.salesPaymentCondition.Location = new System.Drawing.Point(584, 535);
            this.salesPaymentCondition.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.salesPaymentCondition.Name = "salesPaymentCondition";
            this.salesPaymentCondition.Size = new System.Drawing.Size(132, 24);
            this.salesPaymentCondition.TabIndex = 15;
            this.salesPaymentCondition.TextChanged += new System.EventHandler(this.salesPaymentCondition_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 542);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "PaymetnCondition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quantity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "OrderDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "IsPaid";
            // 
            // dgwSalesOrder
            // 
            this.dgwSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSalesOrder.Location = new System.Drawing.Point(239, 47);
            this.dgwSalesOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgwSalesOrder.Name = "dgwSalesOrder";
            this.dgwSalesOrder.RowHeadersWidth = 51;
            this.dgwSalesOrder.RowTemplate.Height = 24;
            this.dgwSalesOrder.Size = new System.Drawing.Size(1101, 343);
            this.dgwSalesOrder.TabIndex = 21;
            this.dgwSalesOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // salesQuantity
            // 
            this.salesQuantity.Location = new System.Drawing.Point(146, 199);
            this.salesQuantity.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.salesQuantity.Name = "salesQuantity";
            this.salesQuantity.Size = new System.Drawing.Size(88, 24);
            this.salesQuantity.TabIndex = 22;
            // 
            // salesOrderDate
            // 
            this.salesOrderDate.Location = new System.Drawing.Point(146, 234);
            this.salesOrderDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.salesOrderDate.Name = "salesOrderDate";
            this.salesOrderDate.Size = new System.Drawing.Size(88, 24);
            this.salesOrderDate.TabIndex = 24;
            // 
            // salesCondition
            // 
            this.salesCondition.Location = new System.Drawing.Point(146, 260);
            this.salesCondition.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.salesCondition.Name = "salesCondition";
            this.salesCondition.Size = new System.Drawing.Size(88, 24);
            this.salesCondition.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "ProductName";
            // 
            // salesProductName
            // 
            this.salesProductName.Location = new System.Drawing.Point(146, 170);
            this.salesProductName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.salesProductName.Name = "salesProductName";
            this.salesProductName.Size = new System.Drawing.Size(88, 24);
            this.salesProductName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "CustomerName";
            // 
            // addCustomerName
            // 
            this.addCustomerName.Location = new System.Drawing.Point(146, 18);
            this.addCustomerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addCustomerName.Name = "addCustomerName";
            this.addCustomerName.Size = new System.Drawing.Size(88, 24);
            this.addCustomerName.TabIndex = 29;
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(24, 94);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(208, 38);
            this.addCustomer.TabIndex = 30;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // addCustomerOrder
            // 
            this.addCustomerOrder.Location = new System.Drawing.Point(27, 590);
            this.addCustomerOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addCustomerOrder.Name = "addCustomerOrder";
            this.addCustomerOrder.Size = new System.Drawing.Size(208, 50);
            this.addCustomerOrder.TabIndex = 31;
            this.addCustomerOrder.Text = "Add Customer Order";
            this.addCustomerOrder.UseVisualStyleBackColor = true;
            this.addCustomerOrder.Click += new System.EventHandler(this.addCustomerOrder_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 320);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 44);
            this.button3.TabIndex = 32;
            this.button3.Text = "Update Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 464);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 44);
            this.button5.TabIndex = 34;
            this.button5.Text = "Delete Order";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // orderConfirmText
            // 
            this.orderConfirmText.Location = new System.Drawing.Point(1184, 464);
            this.orderConfirmText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.orderConfirmText.Name = "orderConfirmText";
            this.orderConfirmText.Size = new System.Drawing.Size(156, 24);
            this.orderConfirmText.TabIndex = 35;
            // 
            // confirmOrderBtn
            // 
            this.confirmOrderBtn.Location = new System.Drawing.Point(872, 431);
            this.confirmOrderBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.confirmOrderBtn.Name = "confirmOrderBtn";
            this.confirmOrderBtn.Size = new System.Drawing.Size(245, 92);
            this.confirmOrderBtn.TabIndex = 36;
            this.confirmOrderBtn.Text = "CONFIRM FOR SUPPLİER ORDER \r\nIF YOU WANT CONFİRM PLEASE TEXT \"\r\nUNDERSTAND\"";
            this.confirmOrderBtn.UseVisualStyleBackColor = true;
            this.confirmOrderBtn.Click += new System.EventHandler(this.confirmOrderBtn_Click);
            // 
            // confirmBackConditionBtn
            // 
            this.confirmBackConditionBtn.Location = new System.Drawing.Point(870, 570);
            this.confirmBackConditionBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.confirmBackConditionBtn.Name = "confirmBackConditionBtn";
            this.confirmBackConditionBtn.Size = new System.Drawing.Size(245, 91);
            this.confirmBackConditionBtn.TabIndex = 37;
            this.confirmBackConditionBtn.Text = "CONFIRM FOR BACK ORDER CONDITION \r\nIF YOU WANT CONFİRM PLEASE TEXT \"\r\nUNDERSTAND\"" +
    "";
            this.confirmBackConditionBtn.UseVisualStyleBackColor = true;
            this.confirmBackConditionBtn.Click += new System.EventHandler(this.confirmBackConditionBtn_Click);
            // 
            // confirmBackCondition
            // 
            this.confirmBackCondition.Location = new System.Drawing.Point(1184, 604);
            this.confirmBackCondition.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.confirmBackCondition.Name = "confirmBackCondition";
            this.confirmBackCondition.Size = new System.Drawing.Size(156, 24);
            this.confirmBackCondition.TabIndex = 38;
            // 
            // searchCustomerName
            // 
            this.searchCustomerName.Location = new System.Drawing.Point(1155, 11);
            this.searchCustomerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.searchCustomerName.Name = "searchCustomerName";
            this.searchCustomerName.Size = new System.Drawing.Size(185, 24);
            this.searchCustomerName.TabIndex = 39;
            this.searchCustomerName.TextChanged += new System.EventHandler(this.searchCustomerName_TextChanged);
            // 
            // showAllOrders
            // 
            this.showAllOrders.Location = new System.Drawing.Point(584, 2);
            this.showAllOrders.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.showAllOrders.Name = "showAllOrders";
            this.showAllOrders.Size = new System.Drawing.Size(218, 41);
            this.showAllOrders.TabIndex = 41;
            this.showAllOrders.Text = "Click For Show All Orders and Refresh";
            this.showAllOrders.UseVisualStyleBackColor = true;
            this.showAllOrders.Click += new System.EventHandler(this.showAllOrders_Click);
            // 
            // showUnpaidOrders
            // 
            this.showUnpaidOrders.Location = new System.Drawing.Point(239, 2);
            this.showUnpaidOrders.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.showUnpaidOrders.Name = "showUnpaidOrders";
            this.showUnpaidOrders.Size = new System.Drawing.Size(218, 41);
            this.showUnpaidOrders.TabIndex = 42;
            this.showUnpaidOrders.Text = "Click For Show Only Unpaid Orders";
            this.showUnpaidOrders.UseVisualStyleBackColor = true;
            this.showUnpaidOrders.Click += new System.EventHandler(this.showUnpaidOrders_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(930, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Seacrh With Customer Name";
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 688);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showUnpaidOrders);
            this.Controls.Add(this.showAllOrders);
            this.Controls.Add(this.searchCustomerName);
            this.Controls.Add(this.confirmBackCondition);
            this.Controls.Add(this.confirmBackConditionBtn);
            this.Controls.Add(this.confirmOrderBtn);
            this.Controls.Add(this.orderConfirmText);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addCustomerOrder);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.addCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesProductName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.salesCondition);
            this.Controls.Add(this.salesOrderDate);
            this.Controls.Add(this.salesQuantity);
            this.Controls.Add(this.dgwSalesOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salesPaymentCondition);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerContact);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
        private System.Windows.Forms.TextBox salesPaymentCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgwSalesOrder;
        private System.Windows.Forms.TextBox salesQuantity;
        private System.Windows.Forms.TextBox salesOrderDate;
        private System.Windows.Forms.TextBox salesCondition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox salesProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addCustomerName;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button addCustomerOrder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox orderConfirmText;
        private System.Windows.Forms.Button confirmOrderBtn;
        private System.Windows.Forms.Button confirmBackConditionBtn;
        private System.Windows.Forms.TextBox confirmBackCondition;
        private System.Windows.Forms.TextBox searchCustomerName;
        private System.Windows.Forms.Button showAllOrders;
        private System.Windows.Forms.Button showUnpaidOrders;
        private System.Windows.Forms.Label label11;
    }
}