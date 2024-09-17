using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WareHouseController3;

namespace WareHouseController3
{
    public partial class CustomerOrderForm : Form
    {
        SalesOrderDal _salesOrderDal = new SalesOrderDal();
        ProductDal _productDal = new ProductDal();
        CustomerDal _customerDal = new CustomerDal();
        ProfitDal _profitDal = new ProfitDal();
        public CustomerOrderForm()
        {
            InitializeComponent();
            dgwSalesOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ispaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            isunpaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            veresiyeode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            orderid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            müsteriismi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            urunismi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            paidAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // SetupFormLayout();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void LoadProducts()
        {
            dgwSalesOrder.DataSource = _salesOrderDal.GetAll();
            dgwSalesOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwSalesOrder.Columns["ProductName"].HeaderText = "Ürün İsim";
            dgwSalesOrder.Columns["CustomerName"].HeaderText = "Müşteri İsim";
            dgwSalesOrder.Columns["CustomerAddress"].HeaderText = "Müşteri Adresi";
            dgwSalesOrder.Columns["CustomerContact"].HeaderText = "Müşteri İletişim";
            dgwSalesOrder.Columns["Quantity"].HeaderText = "Miktar";
            dgwSalesOrder.Columns["TotalPrice"].HeaderText = "Toplam Fiyat";
            dgwSalesOrder.Columns["OrderDate"].HeaderText = "Satış Tarihi";
            dgwSalesOrder.Columns["PaidAmount"].HeaderText = "Ödenen Para";
            dgwSalesOrder.Columns["RemainingAmount"].HeaderText = "Kalan Para";
            dgwSalesOrder.Columns["IsPaid"].HeaderText = "Nakit Ödenme Durumu";

        }
        private void dgwSalesOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // IsPaid sütununun indeksini kontrol edin. Bu, DataGridView'daki IsPaid sütununun indeksidir.
            // İndeks numarasını uygun şekilde ayarlayın.
            int isPaidColumnIndex = 3; // Örneğin, 3. sütun IsPaid sütunu ise.

            if (e.ColumnIndex == isPaidColumnIndex)
            {
                // Hücredeki değeri al
                bool isPaid = (bool)e.Value;

                // IsPaid false olsa bile, hücreyi mavi tik olarak göster.
                // dgwSalesOrder satırındaki PaidAmount ve TotalPrice sütunlarına erişiyoruz
                decimal paidAmount = Convert.ToDecimal(dgwSalesOrder.Rows[e.RowIndex].Cells["PaidAmount"].Value);
                decimal totalPrice = Convert.ToDecimal(dgwSalesOrder.Rows[e.RowIndex].Cells["TotalPrice"].Value);

                // Eğer ödenen miktar toplam fiyatı geçtiyse
                if (paidAmount >= totalPrice)
                {
                    e.Value = "✓"; // Basit bir onay işareti ekleme
                    e.FormattingApplied = true; // Hücre formatının uygulandığını belirtin.
                    e.CellStyle.ForeColor = Color.Blue; // Yazı rengini mavi yapın.
                }
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            orderid.Text = dgwSalesOrder.CurrentRow.Cells[0].Value.ToString();
            salesProductName.Text = dgwSalesOrder.CurrentRow.Cells[1].Value.ToString();
            customerName.Text = dgwSalesOrder.CurrentRow.Cells[2].Value.ToString();
            salesQuantity.Text = dgwSalesOrder.CurrentRow.Cells[5].Value.ToString();
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == salesProductName.Text);
            müsteriismi.Text = dgwSalesOrder.CurrentRow.Cells[2].Value.ToString();
            urunismi.Text = dgwSalesOrder.CurrentRow.Cells[1].Value.ToString();
            if (dgwSalesOrder.CurrentRow.Cells[8].Value.ToString() == "True")
            {
                paid.Checked = true;
                unpaid.Checked = false;
            }
            else
            {
                paid.Checked = false;
                unpaid.Checked = true;
            }
            if (dgwSalesOrder.CurrentRow.Cells[8].Value.ToString() == "True")
            {
                ispaid.Checked = true;
                isunpaid.Checked = false;
            }
            else
            {
                ispaid.Checked = false;
                isunpaid.Checked = true;
            }
            //salesPaymentCondition.Text = dgwSalesOrder.CurrentRow.Cells[8].Value.ToString();
            LoadProducts();
        }

        private void addCustomerOrder_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(salesProductName.Text.ToLower(), out string salesproductname)) return;
            //if (!InputValidator.ValidateString(customerName.Text.ToLower(), out string customername)) return;
            if (!InputValidator.ValidateInt(salesQuantity.Text.ToLower(), out int quantity)) return;

            var customer = _customerDal.GetAll().FirstOrDefault(p => p.Name == customerName.Text);
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == salesproductname);
            //var totalprice = product.UnitPrice * quantity;


            if (product == null)
            {
                MessageBox.Show("ÜRÜN DEPODA BULUNAMADI");
                return;
            }

            if (product.StockAmount < quantity)
            {
                MessageBox.Show("DEPODA YETERLİ ÜRÜN STOĞU YOK");
                return;
            }

            if (quantity < 0)
            {
                MessageBox.Show("MİKTAR SIFIRDAN KÜÇÜK OLAMAZ");
                return;
            }

            if (quantity == 0)
            {
                MessageBox.Show("MİKTAR SIFIR OLAMAZ");
                return;
            }

            // Müşteri yoksa ya da adı boşsa bu alanlar doldurulacak
            if (customer == null)
            {
                var customereName = string.IsNullOrEmpty(customerName.Text) ? "Müşteri ismi yok" : customerName.Text;
                var customereAddress = string.IsNullOrEmpty(customerAddress.Text) ? "Adres yok" : customerAddress.Text;
                var customereContact = string.IsNullOrEmpty(customerContact.Text) ? "İletişim yok" : customerContact.Text;


                _salesOrderDal.AddNew(new SalesOrder
                {
                    ProductName = salesproductname,
                    CustomerName = customereName,
                    CustomerAddress = customereAddress,
                    CustomerContact = customereContact,
                    Quantity = quantity,
                    TotalPrice = product.UnitPrice * quantity,
                    OrderDate = DateTime.Now,
                    IsPaid = paid.Checked
                });
            }
            else
            {
                _salesOrderDal.AddNew(new SalesOrder
                {
                    ProductName = salesproductname,
                    CustomerName = customer.Name,
                    CustomerAddress = customer.Address,
                    CustomerContact = customer.ContactInfo,
                    Quantity = quantity,
                    TotalPrice = product.UnitPrice * quantity,
                    OrderDate = DateTime.Now,
                    IsPaid = paid.Checked
                });
            }

            //var totalprice = product.UnitPrice * quantity;



            // Stok güncellemesi
            product.StockAmount -= quantity;
            _productDal.Update(product);

            // Ürünleri ve formu güncelle
            LoadProducts();
            MessageBox.Show("EMİR EKLENDİ");
        }


        private void salesPaymentCondition_TextChanged(object sender, EventArgs e)
        {

        }
        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
     "ÜRÜNÜ ÖDENDİ OLARAK İŞARETLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?",
     "Ürün Zaten Mevcut",
     MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var orderId = Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value);
                var entity = _salesOrderDal.GetAll().FirstOrDefault(p => p.Id == orderId);
                var product = _productDal.GetAll().FirstOrDefault(p => p.Name == entity.ProductName);
                if (!InputValidator.ValidateInt(salesQuantity.Text.ToLower(), out int quantity)) return;
                if (!InputValidator.ValidateString(salesProductName.Text.ToLower(), out string salesproductname)) return;
                if (entity != null)
                {
                    entity.IsPaid = true;
                    var entityproduct = _productDal.GetAll().FirstOrDefault(p => p.Name == salesproductname);
                    entityproduct.StockAmount -= quantity;
                    _productDal.Update(entityproduct);
                    _salesOrderDal.Update(entity); // Veritabanında güncelleme yapın
                    LoadProducts(); // Verileri yeniden yükleyin
                    MessageBox.Show("EMİR ÖDENDİ");
                }
            }
            else
            {
                MessageBox.Show("EMİR ÖDENDİ OLARAK İŞARETLENEMEDİ");
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
                var entity = _salesOrderDal.GetAll().FirstOrDefault(p => p.Id == orderId);
                if (!InputValidator.ValidateInt(salesQuantity.Text.ToLower(), out int quantity)) return;
                if (!InputValidator.ValidateString(salesProductName.Text.ToLower(), out string salesproductname)) return;
                if (entity != null)
                {
                    entity.IsPaid = false;
                    var entityproduct = _productDal.GetAll().FirstOrDefault(p => p.Name == salesproductname);
                    entityproduct.StockAmount += quantity;
                    _productDal.Update(entityproduct);
                    _salesOrderDal.Update(entity); // Veritabanında güncelleme yapın
                    LoadProducts(); // Verileri yeniden yükleyin
                    MessageBox.Show("EMİR ÖDENMESİ GERİ ALINDI");
                }
            }
            else
            {
                MessageBox.Show("EMİR ÖDENMEDİ OLARAK İŞARETLENEMEDİ");
            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
            var entity = _salesOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == salesProductName.Text);
            if (entity != null)
            {
                _salesOrderDal.Delete(entity);
                product.StockAmount += entity.Quantity;
                _productDal.Update(product);
                LoadProducts();
                MessageBox.Show("EMİR SİLİNDİ");
            }
        }

        private void searchCustomerName_TextChanged(object sender, EventArgs e)
        {
            using (var context = new WareHouseControlContext())
            {
                var result = context.SalesOrders.Where(p => p.CustomerName.Contains(searchCustomerName.Text)).ToList();
                dgwSalesOrder.DataSource = result;
            }
        }

        private void showAllOrders_Click(object sender, EventArgs e)
        {
            using (var context = new WareHouseControlContext())
            {
                var result = context.SalesOrders.ToList();
                dgwSalesOrder.DataSource = result;
            }
        }
        /// <summary>
        /// 
        /// </summary>

        private void showUnpaidOrders_Click(object sender, EventArgs e)
        {
            using (var context = new WareHouseControlContext())
            {
                var result = context.SalesOrders.Where(p => p.IsPaid == false && p.PaidAmount < p.TotalPrice).ToList();
                dgwSalesOrder.DataSource = result;
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            _customerDal.AddNew(new Customer
            {
                Name = addCustomerName.Text.ToLower(),
                ContactInfo = customerContact.Text.ToLower(),
                Address = customerAddress.Text.ToLower()
            });
        }

        private void salesOrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void paid_CheckedChanged(object sender, EventArgs e)
        {
            if (paid.Checked)
            {
                unpaid.Checked = false;
            }
            else
            {
                unpaid.Checked = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void unpaid_CheckedChanged(object sender, EventArgs e)
        {
            if (unpaid.Checked)
            {
                paid.Checked = false;
            }
            else
            {
                paid.Checked = true;
            }
        }

        private void salesCondition_TextChanged(object sender, EventArgs e)
        {

        }

   private void veresiyeode_Click(object sender, EventArgs e)
        {
            if (isunpaid.Checked == true)
            {
                if (dgwSalesOrder.SelectedRows.Count > 0)
                {
                    var entity = _salesOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
                    var product = _productDal.GetAll().FirstOrDefault(p => p.Name == urunismi.Text);

                    if (entity != null)
                    {
                        decimal paymentAmount;
                        if (!decimal.TryParse(paidAmount.Text, out paymentAmount))
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
                        /*
                        if (entity.PaidAmount >= entity.TotalPrice)
                        {
                            entity.IsPaid = true;
                        }
                        */
                        if (product != null)
                        {
                            var purchasePrice = product.PurchasePrice;
                            var salePrice = product.UnitPrice;
                            var profitAmount = paymentAmount * ((salePrice - purchasePrice) / salePrice);
                            var paidamount = Convert.ToInt32(paidAmount.Text); 
                            var profitPercentage = (salePrice - purchasePrice) / salePrice * 100;
                            var musteriismi = müsteriismi.Text;
                            if(musteriismi == null)
                            {
                                musteriismi = "Müşteri ismi yok";
                                return;
                            }
                            // Kâr nesnesi oluştur
                            var profit = new Profit
                            {
                                ProductName = product.Name,
                                UnitPrice = salePrice,
                                PurchasePrice = purchasePrice,
                                CustomerName = musteriismi,
                                PaidAmount = paidamount,
                                PaidDate = DateTime.Now, // Ödeme tarihi
                                //OrderDate = entity.OrderDate,
                                //IsOnCredit = !entity.IsPaid
                            };

                            // Kârı veritabanına kaydet
                            _profitDal.Add(profit);

                            // Günlük ve aylık kârları güncelle
                            //UpdateProfit(profitAmount, order.OrderDate);
                        }
                        else
                        {
                            MessageBox.Show("Ürün bilgisi bulunamadı.");
                        }
                        entity.RemainingAmount = entity.TotalPrice - entity.PaidAmount;
                        _salesOrderDal.Update(entity);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(idtext.Text, out int id))
            {
                using (var context = new WareHouseControlContext())
                {
                    var result = context.SalesOrders.Where(p => p.Id == id).ToList();
                    dgwSalesOrder.DataSource = result;
                }
            }
        }
    }

}
