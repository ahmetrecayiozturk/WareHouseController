using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WareHouseController3
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
            dgw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addproduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateproduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteproduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchtext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterunitprice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minprice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxprice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterstockamount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minstock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxstock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            supplierorderbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customerorderbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showAllProfitDaily.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showProfitMonthly.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Label ve TextBox bileşenlerinin Anchor özelliklerini ayarlayın
            name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            unitprice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            purchasePrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockamount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchtext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minprice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxprice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minstock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxstock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;

        }
        //Form1'in verilerini başka sayfalar aracılığı ile yükleyebilmek için LoadProducts metodunu public yaptık
        public void LoadProducts()
        {
            // DataGridView'e veriyi bağladıktan sonra başlıkları değiştir
            dgw.DataSource = _productDal.GetAll();
            dgw.Columns["Name"].HeaderText = "İsim";
            dgw.Columns["UnitPrice"].HeaderText = "Ürün Fiyatı";
            dgw.Columns["PurchasePrice"].HeaderText = "Alış Fiyatı";
            dgw.Columns["StockAmount"].HeaderText = "Stok Miktarı";

            // Sütun boyutlarını otomatik olarak dolduracak şekilde ayarla
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void RefreshProducts()
        {
            dgw.Refresh();
        }
        /*
        //Kategori id'sini kaldırdığım için burayı da kaldırıyorum
        private void addproduct_Click(object sender, EventArgs e)
        {
            bool isExist = _productDal.GetAll().Any(p => p.Name == name.Text);
            if (!isExist)

            {
                if (!InputValidator.ValidateDecimal(unitprice.Text.ToLower(), out decimal unitPrice)) return;
                if (!InputValidator.ValidateInt(stockamount.Text.ToLower(), out int stockAmount)) return;
                if (!InputValidator.ValidateInt(categoryid.Text.ToLower(), out int categoryId)) return;
                _productDal.Add(new Product
                {
                    Name = name.Text,
                    UnitPrice = unitPrice,
                    StockAmount = stockAmount,
                    ProductCategoryId = categoryId
                });
                LoadProducts();
                MessageBox.Show("ÜRÜN EKLENDİ");
            }
            else
            {
                MessageBox.Show("ÜRÜN HALIHAZIRDA DEPODA MEVCUT");
            }
        }
        */
        private void addproduct_Click(object sender, EventArgs e)
        {
            bool isExist = _productDal.GetAll().Any(p => p.Name == name.Text);

            if (!isExist)
            {
                if (!InputValidator.ValidateDecimal(unitprice.Text.ToLower(), out decimal unitPrice)) return;
                if (!InputValidator.ValidateDecimal(purchasePrice.Text.ToLower(), out decimal purchaseprice)) return;
                if (!InputValidator.ValidateInt(stockamount.Text.ToLower(), out int stockAmount)) return;
                //Kategori id'sini kaldırdığım için burayı da kaldırıyorum
                //if (!InputValidator.ValidateInt(categoryid.Text.ToLower(), out int categoryId)) return;

                _productDal.Add(new Product
                {
                    Name = name.Text,
                    UnitPrice = unitPrice,
                    StockAmount = stockAmount,
                    PurchasePrice = purchaseprice
                    //Kategori id'sini kaldırdığım için burayı da kaldırıyorum
                    //ProductCategoryId = categoryId
                });
                LoadProducts();
                MessageBox.Show("ÜRÜN EKLENDİ");
            }
            else
            {
                MessageBox.Show(
                    "Ürün Zaten Mevcut"

                );
            }
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            var entity = _productDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgw.CurrentRow.Cells[0].Value));
            if (entity != null)
            {
                entity.Name = name.Text;
                if (!InputValidator.ValidateDecimal(unitprice.Text.ToLower(), out decimal unitPrice)) return;
                if (!InputValidator.ValidateDecimal(purchasePrice.Text.ToLower(), out decimal purchaseprice)) return;
                if (!InputValidator.ValidateInt(stockamount.Text.ToLower(), out int stockAmount)) return;
                //if (!InputValidator.ValidateInt(categoryid.Text.ToLower(), out int categoryId)) return;
                entity.UnitPrice = unitPrice;
                entity.StockAmount = stockAmount;
                entity.PurchasePrice = purchaseprice;
                //Kategori id'si güncellenmeyecek çünkü kategori id'sini kaldırdım
                //entity.ProductCategoryId = categoryId;
                _productDal.Update(entity);
                LoadProducts(); // Verileri yeniden yükle
                MessageBox.Show("ÜRÜN GÜNCELLENDİ");
            }
        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
            var productToDelete = new Product { Id = id };
            _productDal.Delete(productToDelete);
            LoadProducts(); // Verileri yeniden yükle
            MessageBox.Show("ÜRÜN SİLİNDİ");
        }

        private void searchproduct_Click(object sender, EventArgs e)
        {
            var result = _productDal.Search(searchtext.Text);
            dgw.DataSource = result;
        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            unitprice.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            purchasePrice.Text = dgw.CurrentRow.Cells[3].Value.ToString();
            stockamount.Text = dgw.CurrentRow.Cells[4].Value.ToString();
            //Kategori id'sini kaldırdığım için burayı da kaldırıyorum
            //categoryid.Text = dgw.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts(); // Form yüklendiğinde ürünleri yükle
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            var result = _productDal.Search(searchtext.Text.ToLower());
            dgw.DataSource = result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stockamount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        /*
         * Analyze the 'System.FormatException' error bu hatayı veriyor burası
        private void filtercategoryid_Click(object sender, EventArgs e)
        {
            var result = _productDal.GetByCategoryId(id:Convert.ToInt32(categoryidvalue.Text));
            dgw.DataSource = result;
            
         bu da olmadı
            int categoryIdValue;
            categoryIdValue = Convert.ToInt32(categoryidvalue.Text);
            var result = _productDal.GetByCategoryId(id: categoryIdValue);
            dgw.DataSource= result;
     
        }*/

        /*KATEGORİ ID'Yİ KALDIRDIM VE BU YÜZDEN BU KODU KALDIRDIM
        private void filtercategoryid_Click(object sender, EventArgs e)
        {
            
            if(!InputValidator.ValidateInt(categoryidvalue.Text.ToLower(), out int categoryId)) return; 
            var result = _productDal.GetByCategoryId(id: categoryId);
            dgw.DataSource = result;
            
            
        }
        */

        /*
         * Analyze the 'System.FormatException' error bu hatayı veriyor burası
         *         private void filterunitprice_Click(object sender, EventArgs e)
        {
            var result =_productDal.GetByUnitPrice(min : Convert.ToDecimal(minprice.Text), max: Convert.ToDecimal(maxprice.Text));
            dgw.DataSource = result;
        }
        */
        private void filterunitprice_Click(object sender, EventArgs e)
        {
                if (!InputValidator.ValidateDecimal(minprice.Text.ToLower(), out decimal minPrice)) return;
                if (!InputValidator.ValidateDecimal(maxprice.Text.ToLower(), out decimal maxPrice)) return;

                var result = _productDal.GetByUnitPrice(min: minPrice, max: maxPrice);
                dgw.DataSource = result;
            
        }

        /*
         * Analyze the 'System.FormatException' error bu hatayı veriyor burası
        private void filterstockamount_Click(object sender, EventArgs e)
        {
            var result = _productDal.GetByStockAmount(min: Convert.ToInt32(minstock.Text), max: Convert.ToInt32(maxstock.Text));
            dgw.DataSource = result;
        } 
        */
        private void filterstockamount_Click(object sender, EventArgs e)
        {

            if (!InputValidator.ValidateInt(minstock.Text.ToLower(), out int minStock)) return;
            if (!InputValidator.ValidateInt(maxstock.Text.ToLower(), out int maxStock)) return;
            var result = _productDal.GetByStockAmount(min: minStock, max: maxStock);
            dgw.DataSource = result;
            
        }

        private void supplierorderbtn_Click(object sender, EventArgs e)
        {
            orderConfirmText2 orderform = new orderConfirmText2();
            orderform.Show();
            Form1 form1 = new Form1();
            form1.Hide();
            /*
            // Seçili ürünü al
            if (!InputValidator.ValidateInt(productIdTextBox.Text, out int productId)) return;

            // OrderDetailsForm'u aç
            using (var orderDetailsForm = new OrderDetailsForm())
            {
                if (orderDetailsForm.ShowDialog() == DialogResult.OK)
                {
                    // Formdan bilgileri al
                    int customerId = Convert.ToInt32(orderDetailsForm.CustomerId);
                    string supplierName = orderDetailsForm.SupplierName;
                    string supplierContactInfo = orderDetailsForm.SupplierContactInfo;
                    string supplierAddress = orderDetailsForm.SupplierAddress;
                    int quantity = Convert.ToInt32(quantityTextBox.Text); // Ürün miktarı

                    // Sipariş oluştur
                    bool isOrderCreated = OrderHelper.TryCreatePurchaseOrder(
                        productDal: _productDal,
                        purchaseOrderDal: new PurchaseOrderDal(),
                        productId: productId,
                        supplierId: customerId, // Bu senaryoda supplierId yerine customerId kullanılmış, tedarikçi ilişkisi gerektiriyorsa bunu ayarlayın.
                        quantity: quantity
                    );

                    if (isOrderCreated)
                    {
                        MessageBox.Show("Sipariş başarıyla oluşturuldu.");
                        LoadProducts(); // Ürün listesini güncelle
                    }
                    else
                    {
                        MessageBox.Show("Sipariş oluşturulamadı. Ürün bulunamadı.");
                    }
                }
            }
            */
        }


        private void customerorderbtn_Click(object sender, EventArgs e)
        {
            CustomerOrderForm customerOrderForm = new CustomerOrderForm();
            customerOrderForm.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dgw.DataSource = _productDal.GetAll();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            dgw.DataSource = _productDal.GetAll();
        }

        private void showSuppliers_Click(object sender, EventArgs e)
        {
            Form Supplier = new Suppliers();
            Supplier.Show();
        }

        private void showCustomers_Click(object sender, EventArgs e)
        {
            Form Customers = new Customers();
            Customers.Show();
        }

        private void showAllProfitDaily_Click(object sender, EventArgs e)
        {
            Form ShowDailyProfit = new ShowDailyProfit();
            ShowDailyProfit.Show();
        }

        private void showProfitMonthly_Click(object sender, EventArgs e)
        {
            Form MonthlyProfit = new MonthlyProfit();
            MonthlyProfit.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}