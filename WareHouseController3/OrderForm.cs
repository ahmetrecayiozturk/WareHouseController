using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class orderConfirmText2 : Form
    {
        private readonly SalesOrderDal _salesOrderDal = new SalesOrderDal();
        private readonly PurchaseOrderDal _purchaseOrderDal = new PurchaseOrderDal();
        ProductDal _productDal = new ProductDal();
        SupplierDal _supplierDal = new SupplierDal();
        public orderConfirmText2()
        {
            InitializeComponent();
            dgwSalesOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ispaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            isunpaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            borcode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            orderid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tedarikciismii.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            urunismii.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            paidAmountt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        }
        /*
        private void LoadOrders()
        {
            var unpaidSalesOrders = _salesOrderDal.GetUnpaidOrders();
            var unpaidPurchaseOrders = _purchaseOrderDal.GetUnpaidOrders();

            // Tabloya veya listbox'a veri yükleyin
            // Örneğin: salesOrdersDataGridView.DataSource = unpaidSalesOrders;
            // Örneğin: purchaseOrdersDataGridView.DataSource = unpaidPurchaseOrders;
        }*/

        public void LoadOrders()
        {
            dgwSalesOrder.DataSource = _purchaseOrderDal.GetAll();
            dgwSalesOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwSalesOrder.Columns["ProductName"].HeaderText = "Ürün İsim";
            dgwSalesOrder.Columns["SupplierName"].HeaderText = "Tedarikçi İsim";
            dgwSalesOrder.Columns["Address"].HeaderText = "Tedarikçi Adresi";
            dgwSalesOrder.Columns["ContactInfo"].HeaderText = "Tedarikçi İletişim";
            dgwSalesOrder.Columns["Quantity"].HeaderText = "Miktar";
            dgwSalesOrder.Columns["TotalPrice"].HeaderText = "Toplam Fiyat";
            dgwSalesOrder.Columns["PaidAmount"].HeaderText = "Ödenen Para";
            dgwSalesOrder.Columns["RemainingAmount"].HeaderText = "Kalan Para";
            dgwSalesOrder.Columns["OrderDate"].HeaderText = "Alış Tarihi";
            dgwSalesOrder.Columns["IsDelivered"].HeaderText = "Teslim Durumu";
            dgwSalesOrder.Columns["IsPaid"].HeaderText = "Ödenme Durumu";

        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnAddSalesOrder_Click(object sender, EventArgs e)
        {
            // Satış emri eklemek için gerekli kod
            // Satış emri oluşturma işlemi
            string productName = txtProductId.Text;
            string customerName = txtCustomerId.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);

            if (OrderHelper.TryCreateSalesOrder(_productDal, _salesOrderDal, productName, customerName, quantity, out var product))
            {
                MessageBox.Show("Sales order created successfully.");
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Failed to create sales order.");
            }
        }

        private void btnMarkSalesOrderAsPaid_Click(object sender, EventArgs e)
        {
            // Satış emrini ödeme olarak işaretleme
            int orderId = Convert.ToInt32(txtOrderId.Text);
            DateTime paymentDate = DateTime.Now;

            _salesOrderDal.MarkAsPaid(orderId, paymentDate);
            MessageBox.Show("Sales order marked as pad.");
            LoadOrders();
        }

        private void btnAddPurchaseOrder_Click(object sender, EventArgs e)
        {
            // Satın alma emri eklemek için gerekli kod
            // Satın alma emri oluşturma işlemi
            string productName = txtProductId.Text;
            string supplierName = txtSupplierId.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);

            if (OrderHelper.TryCreatePurchaseOrder(_productDal, _purchaseOrderDal, productName, supplierName, quantity))
            {
                MessageBox.Show("EMİR BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ.");
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Failed to create purchase order.");
            }
        }

        private void btnMarkPurchaseOrderAsPaid_Click(object sender, EventArgs e)
        {
            // Satın alma emrini ödeme olarak işaretleme
            int orderId = Convert.ToInt32(txtOrderId.Text);
            DateTime paymentDate = DateTime.Now;

            _purchaseOrderDal.MarkAsPaid(orderId, paymentDate);
            MessageBox.Show("Purchase order marked as paid.");
            LoadOrders();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwSalesOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderid.Text = dgwSalesOrder.CurrentRow.Cells[0].Value.ToString();
            productName.Text = dgwSalesOrder.CurrentRow.Cells[1].Value.ToString();
            supplierName.Text = dgwSalesOrder.CurrentRow.Cells[2].Value.ToString();
            productQuantity.Text = dgwSalesOrder.CurrentRow.Cells[5].Value.ToString();
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == productName.Text);
            tedarikciismii.Text = dgwSalesOrder.CurrentRow.Cells[2].Value.ToString();
            urunismii.Text = dgwSalesOrder.CurrentRow.Cells[1].Value.ToString();
            if (dgwSalesOrder.CurrentRow.Cells[11].Value.ToString() == "True")
            {
                ispaidd.Checked = true;
                isunpaidd.Checked = false;
            }
            else
            {
                isunpaidd.Checked = true;
                ispaidd.Checked = false;
            }
            if (dgwSalesOrder.CurrentRow.Cells[11].Value.ToString() == "True")
            {
                ispaid.Checked = true;
                isunpaid.Checked = false;
            }
            else
            {
                ispaid.Checked = false;
                isunpaid.Checked = true;
            }
            //IsDelivered.Text = dgwSalesOrder.CurrentRow.Cells[8].Value.ToString();
            LoadOrders();
        }

        private void addSupplierOrder_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(productName.Text.ToLower(), out string productname)) return;
            if (!InputValidator.ValidateString(supplierName.Text.ToLower(), out string suppliername)) return;
            if (!InputValidator.ValidateInt(productQuantity.Text.ToLower(), out int quantity)) return;
            //if (!InputValidator.ValidateInt(salesprice.Text.ToLower(), out int salesPrice)) return;
            //if (!InputValidator.ValidateInt(purchaseprice.Text.ToLower(), out int purchasePrice)) return;
            
            //if (!InputValidator.ValidateDateTime(supplierDate.Text.ToLower(), out DateTime orderdate)) return;
            //if (!InputValidator.ValidateBoolean(IsDelivered.Text.ToLower(), out bool paidcondition)) return;
            var supplier = _supplierDal.GetAll().FirstOrDefault(p => p.Name == suppliername);
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == productname);
            decimal salespricee;
            decimal purchaseepricee;
            if (int.TryParse(salesprice.Text, out int price))
            {
                salespricee = price;
            }
            else
            {
                salespricee = product.UnitPrice;
            }
            if (int.TryParse(purchaseprice.Text, out int pricee))
            {
                purchaseepricee = pricee;
            }
            else
            {
                purchaseepricee = product.PurchasePrice;
            }
            var tottalprice = purchaseepricee * quantity;
            if (supplier == null)
            {
                MessageBox.Show("TEDARİKÇİ BULUNAMADI");
                return;
            }
            if (quantity < 0)
            {
                MessageBox.Show("SIFIRDAN AZ MİKTAR GİRİLEMEZ");
                return;
            }
            if (quantity == 0)
            {
                MessageBox.Show("MİKTAR SIFIR OLAMAZ");
                return;
            }
            if (product != null)
            {
                if(isdelivered.Checked == true)
                {
                    product.StockAmount += quantity;
                    _productDal.Update(product);
                }
                _purchaseOrderDal.AddNew(new PurchaseOrder
                {
                    ProductName = productname,
                    SupplierName = suppliername,
                    Address = supplier.Address,
                    ContactInfo = supplier.ContactInfo,
                    Quantity = quantity,
                    TotalPrice = purchaseepricee * quantity,
                    OrderDate = DateTime.Now,
                    IsDelivered = isdelivered.Checked,
                    IsPaid = ispaidd.Checked
                });
                LoadOrders();
                MessageBox.Show("ÜRÜN ZATEN MEVCUT");
                return;
            }
            else
            {
                _purchaseOrderDal.AddNew(new PurchaseOrder
                {
                    ProductName = productname,
                    SupplierName = suppliername,
                    Address = supplier.Address,
                    ContactInfo = supplier.ContactInfo,
                    Quantity = quantity,
                    TotalPrice = purchaseepricee * quantity,
                    OrderDate = DateTime.Now,
                    IsDelivered = isdelivered.Checked,
                    IsPaid = ispaidd.Checked
                });
                _productDal.AddNew(new Product
                {
                    Name = productname,
                    UnitPrice = salespricee,
                    PurchasePrice = purchaseepricee,
                    StockAmount = quantity
                });

                LoadOrders();
                MessageBox.Show("EMİR EKLENDİ");
            }

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(addSupplierName.Text.ToLower(), out string suppliername)) return;
            if (!InputValidator.ValidateString(addSupplierContact.Text.ToLower(), out string suppliercontact)) return;
            if (!InputValidator.ValidateString(supplierAddress.Text.ToLower(), out string supplieraddress)) return;
            _supplierDal.AddNew(new Supplier
            {
                Name = suppliername,
                ContactInfo = suppliercontact,
                Address = supplieraddress
            });

        }

        private void deleteSupplier_Click(object sender, EventArgs e)
        {
            var entity = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == productName.Text.ToLower());
            if (entity != null)
            {
                _purchaseOrderDal.Delete(entity);
                if (entity.IsPaid == true)
                {
                    product.StockAmount -= entity.Quantity;
                    _productDal.Update(product);
                }
                _productDal.Update(product);
                LoadOrders();
                MessageBox.Show("EMİR SİLİNDİ");
            }
        }

        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
     "EMİRİ TESLİM ALINDI OLARAK İŞARETLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?",
     "Ürün Zaten Mevcut",
     MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var orderId = Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value);
                var entity = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == orderId);
                var product = _productDal.GetAll().FirstOrDefault(p => p.Name == entity.ProductName);
                if (entity != null)
                {
                    entity.IsPaid = true;
                    product.StockAmount += entity.Quantity;
                    _productDal.Update(product);
                    _purchaseOrderDal.Update(entity); // Veritabanında güncelleme yapın
                    LoadOrders(); // Verileri yeniden yükleyin
                    MessageBox.Show("ÜRÜN TESLİM ALINDI");
                }
            }
            else
            {
                MessageBox.Show("ÜRÜN TESLİM ALINAMADI");
            }
            
        }

        private void confirmBackConditionBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
     "ÜRÜNÜ ÖDENMEDİ OLARAK İŞARETLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?",
     "Ürün Zaten Mevcut",
     MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var orderId = Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value);
                var entity = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == orderId);
                var product = _productDal.GetAll().FirstOrDefault(p => p.Name == entity.ProductName);
                if (entity != null)
                {
                    entity.IsPaid = false;
                    product.StockAmount -= entity.Quantity;
                    _productDal.Update(product);
                    _purchaseOrderDal.Update(entity); // Veritabanında güncelleme yapın
                    LoadOrders(); // Verileri yeniden yükleyin
                    MessageBox.Show("ÜRÜNÜN TESLİM ALINMASI GERİ ALINDI");
                }
            }
            else
            {
                MessageBox.Show("ÜRÜNÜN TESLİM ALINMASI GERİ ALINMASI GERİ ALINAMADI");
            }
        }

        private void searchCustomerName_TextChanged(object sender, EventArgs e)
        {
            using (var context = new WareHouseControlContext())
            {
                var result = context.PurchaseOrders.Where(p => p.SupplierName.Contains(searchSupplierName.Text.ToLower())).ToList();
                dgwSalesOrder.DataSource = result;
            }
        }

        private void showUnpaidOrders_Click(object sender, EventArgs e)
        {
            using (var context = new WareHouseControlContext())
            {
                var result = context.PurchaseOrders.Where(p => p.IsPaid == false).ToList();
                dgwSalesOrder.DataSource = result;
            }
        }

        private void showAllOrders_Click(object sender, EventArgs e)
        {
            var result = _purchaseOrderDal.GetAll();
            dgwSalesOrder.DataSource = result;
        }

        private void purchasePaymentCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var product =_productDal.GetAll().FirstOrDefault(p => p.Name == productName.Text);
            if (product != null)
            {
                MessageBox.Show("Mevcut Ürünü Alış ve Satış Fiyatı Buradan Değişemez");
            }
        }

        private void paidAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void borcode_Click(object sender, EventArgs e)
        {
            if (isunpaidd.Checked == true)
            {
                if (dgwSalesOrder.SelectedRows.Count > 0)
                {
                    var entity = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
                    var product = _productDal.GetAll().FirstOrDefault(p => p.Name == urunismii.Text);

                    if (entity != null)
                    {
                        decimal paymentAmount;
                        if (!decimal.TryParse(paidAmountt.Text, out paymentAmount))
                        {
                            MessageBox.Show("Geçerli bir ödeme miktarı girin.");
                            return;
                        }

                        decimal remainingAmount = entity.TotalPrice - entity.PaidAmount;
                        if (paymentAmount > remainingAmount)
                        {
                            MessageBox.Show("Ödenen miktar kalan borçtan fazla olamaz.");
                            return;
                        }

                        // Ödenen miktarı borçtan düş
                        entity.PaidAmount += paymentAmount;
                        if (entity.PaidAmount >= entity.TotalPrice)
                        {
                            entity.IsPaid = true;
                        }

                        if (product != null)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Ürün bilgisi bulunamadı.");
                        }
                        entity.RemainingAmount = entity.TotalPrice - entity.PaidAmount;
                        _purchaseOrderDal.Update(entity);
                        //LoadUnpaidOrders();
                        MessageBox.Show("Ödeme başarıyla tamamlandı.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen ödeme yapmak için bir veresiye seçin.");
                }
            }
            else
            {
                MessageBox.Show("ÖDENMİŞ EMİRİ ÖDEYEMEZSİNİZ");
            }
        }

        private void delivered_CheckedChanged(object sender, EventArgs e)
        {
            if (ispaidd.Checked)
            {
                isunpaidd.Checked = false;
            }
            else
            {
                isunpaidd.Checked = true;
            }
        }

        private void undelivered_CheckedChanged(object sender, EventArgs e)
        {
            if (isunpaidd.Checked)
            {
                ispaidd.Checked = false;
            }
            else
            {
                ispaidd.Checked = true;
            }
        }

        private void idtext_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(idtext.Text, out int id))
            {
                using (var context = new WareHouseControlContext())
                {
                    var result = context.PurchaseOrders.Where(p => p.Id == id).ToList();
                    dgwSalesOrder.DataSource = result;
                }
            }

        }

        private void salesprice_TextChanged(object sender, EventArgs e)
        {
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == productName.Text);
            if (product != null)
            {
                MessageBox.Show("Mevcut Ürünü Alış ve Satış Fiyatı Buradan Değişemez");
            }
        }
        /*
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
     "EMİRİ TESLİM ALINDI OLARAK İŞARETLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?",
     "Ürün Zaten Mevcut",
     MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)

            {
                var orderId = Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value);
                var entity = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == orderId);
                var product = _productDal.GetAll().FirstOrDefault(p => p.Name == entity.ProductName);
                if (entity != null)
                {
                    entity.IsDelivered = true;
                    product.StockAmount += entity.Quantity;
                    _productDal.Update(product);
                    _purchaseOrderDal.Update(entity); // Veritabanında güncelleme yapın
                    LoadOrders(); // Verileri yeniden yükleyin
                    MessageBox.Show("ÜRÜN TESLİM ALINDI");
                }
                else
                {
                    MessageBox.Show("LÜTFEN BİR ÜRÜN SEÇİNİZ");
                }
            }
            else
            {
                MessageBox.Show("ÜRÜN TESLİM ALINAMADI");
            }
        }
        */
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "EMİRİ TESLİM ALINDI OLARAK İŞARETLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?",
                "Ürün Zaten Mevcut",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgwSalesOrder.CurrentRow != null && dgwSalesOrder.CurrentRow.Cells[0].Value != null)
                {
                    var orderId = Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value);
                    var entity = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == orderId);
                    var product = _productDal.GetAll().FirstOrDefault(p => p.Name == entity?.ProductName);

                    if (entity != null)
                    {
                        entity.IsDelivered = true;
                        product.StockAmount += entity.Quantity;
                        _productDal.Update(product);
                        _purchaseOrderDal.Update(entity); // Veritabanında güncelleme yapın
                        LoadOrders(); // Verileri yeniden yükleyin
                        MessageBox.Show("ÜRÜN TESLİM ALINDI");
                    }
                    else
                    {
                        MessageBox.Show("LÜTFEN BİR ÜRÜN SEÇİNİZ");
                    }
                }
                else
                {
                    MessageBox.Show("LÜTFEN BİR ÜRÜN SEÇİNİZ");
                }
            }
            else
            {
                MessageBox.Show("ÜRÜN TESLİM ALINAMADI");
            }
        }

        private void isdelivered_CheckedChanged(object sender, EventArgs e)
        {
            if (isdelivered.Checked)
            {
                isundelivered.Checked = false;
            }
            else
            {
                isundelivered.Checked = true;
            }
        }

        private void isundelivered_CheckedChanged(object sender, EventArgs e)
        {
            if (isundelivered.Checked)
            {
                isdelivered.Checked = false;
            }
            else
            {
                isdelivered.Checked = true;
            }
        }

        private void ispaid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void isunpaid_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
