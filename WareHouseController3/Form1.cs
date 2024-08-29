using System;
using System.Linq;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }
        //Form1'in verilerini başka sayfalar aracılığı ile yükleyebilmek için LoadProducts metodunu public yaptık
        public void LoadProducts()
        {
            dgw.DataSource = _productDal.GetAll();
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void RefreshProducts()
        {
            dgw.Refresh();
        }
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
            }
            else
            {
                MessageBox.Show("Product already exists");
            }
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            var entity = _productDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgw.CurrentRow.Cells[0].Value));
            if (entity != null)
            {
                entity.Name = name.Text;
                if (!InputValidator.ValidateDecimal(unitprice.Text.ToLower(), out decimal unitPrice)) return;
                if(!InputValidator.ValidateInt(stockamount.Text.ToLower(), out int stockAmount)) return;
                if (!InputValidator.ValidateInt(categoryid.Text.ToLower(), out int categoryId)) return;
                entity.UnitPrice = unitPrice;
                entity.StockAmount = stockAmount;
                entity.ProductCategoryId = categoryId;
                _productDal.Update(entity);
                LoadProducts(); // Verileri yeniden yükle
            }
        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
            var productToDelete = new Product { Id = id };
            _productDal.Delete(productToDelete);
            LoadProducts(); // Verileri yeniden yükle
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
            stockamount.Text = dgw.CurrentRow.Cells[3].Value.ToString();
            categoryid.Text = dgw.CurrentRow.Cells[4].Value.ToString();
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
        private void filtercategoryid_Click(object sender, EventArgs e)
        {
            
            if(!InputValidator.ValidateInt(categoryidvalue.Text.ToLower(), out int categoryId)) return; 
            var result = _productDal.GetByCategoryId(id: categoryId);
            dgw.DataSource = result;
            
            
        }
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
    }
}

/*
using System;
using System.Linq;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        SupplierDal _supplierDal = new SupplierDal();
        CustomerDal _customerDal = new CustomerDal();
        PurchaseOrderDal _purchaseOrderDal = new PurchaseOrderDal();
        SalesOrderDal _salesOrderDal = new SalesOrderDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            dgw.DataSource = _productDal.GetAll();
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            bool isExist = _productDal.GetAll().Any(p => p.Name == name.Text);
            if (!isExist)
            {
                if (!InputValidator.ValidateDecimal(unitprice.Text, out decimal unitPrice)) return;
                if (!InputValidator.ValidateInt(stockamount.Text, out int stockAmount)) return;
                if (!InputValidator.ValidateInt(categoryid.Text, out int categoryId)) return;

                _productDal.Add(new Product
                {
                    Name = name.Text,
                    UnitPrice = unitPrice,
                    StockAmount = stockAmount,
                    ProductCategoryId = categoryId
                });
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Product already exists");
            }
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            var entity = _productDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgw.CurrentRow.Cells[0].Value));
            if (entity != null)
            {
                entity.Name = name.Text;
                if (!InputValidator.ValidateDecimal(unitprice.Text, out decimal unitPrice)) return;
                if (!InputValidator.ValidateInt(stockamount.Text, out int stockAmount)) return;
                if (!InputValidator.ValidateInt(categoryid.Text, out int categoryId)) return;

                entity.UnitPrice = unitPrice;
                entity.StockAmount = stockAmount;
                entity.ProductCategoryId = categoryId;
                _productDal.Update(entity);
                LoadProducts(); // Verileri yeniden yükle
            }
        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
            var productToDelete = new Product { Id = id };
            _productDal.Delete(productToDelete);
            LoadProducts(); // Verileri yeniden yükle
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
            stockamount.Text = dgw.CurrentRow.Cells[3].Value.ToString();
            categoryid.Text = dgw.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts(); // Form yüklendiğinde ürünleri yükle
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            var result = _productDal.Search(searchtext.Text);
            dgw.DataSource = result;
        }

        private void filtercategoryid_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateInt(categoryidvalue.Text, out int categoryId)) return;
            var result = _productDal.GetByCategoryId(id: categoryId);
            dgw.DataSource = result;
        }

        private void filterunitprice_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateDecimal(minprice.Text, out decimal minPrice)) return;
            if (!InputValidator.ValidateDecimal(maxprice.Text, out decimal maxPrice)) return;

            var result = _productDal.GetByUnitPrice(min: minPrice, max: maxPrice);
            dgw.DataSource = result;
        }

        private void filterstockamount_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateInt(minstock.Text, out int minStock)) return;
            if (!InputValidator.ValidateInt(maxstock.Text, out int maxStock)) return;

            var result = _productDal.GetByStockAmount(min: minStock, max: maxStock);
            dgw.DataSource = result;
        }

        private void orderforsupplier_Click(object sender, EventArgs e)
        {
            if (dgw.SelectedRows.Count > 0)
            {
                var productId = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
                var supplierId = Convert.ToInt32(supplierid.Text); // Tedarikçi ID'si

                bool isSuccess = OrderHelper.TryCreatePurchaseOrder(_productDal, _purchaseOrderDal, productId, supplierId, 10); // Örnek: 10 adet sipariş
                if (isSuccess)
                {
                    MessageBox.Show("Purchase order created.");
                }
                else
                {
                    MessageBox.Show("Failed to create purchase order.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private void orderforcustomer_Click(object sender, EventArgs e)
        {
            if (dgw.SelectedRows.Count > 0)
            {
                var productId = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
                var customerId = Convert.ToInt32(customerid.Text); // Müşteri ID'si
                var quantity = Convert.ToInt32(quantity.Text); // Satılan miktar

                bool isSuccess = OrderHelper.TryCreateSalesOrder(_productDal, _salesOrderDal, productId, customerId, quantity, out var updatedProduct);
                if (isSuccess)
                {
                    MessageBox.Show("Sales order created and stock updated.");
                }
                else
                {
                    MessageBox.Show("Insufficient stock or product not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private void showorders_Click(object sender, EventArgs e)
        {
            var purchaseOrders = _purchaseOrderDal.GetAll();
            var salesOrders = _salesOrderDal.GetAll();

            var ordersForm = new OrdersForm(purchaseOrders, salesOrders);
            ordersForm.Show();
        }
    }
}
 
*/



/*
using System;
using System.Linq;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        SupplierDal _supplierDal = new SupplierDal();
        CustomerDal _customerDal = new CustomerDal();
        PurchaseOrderDal _purchaseOrderDal = new PurchaseOrderDal();
        SalesOrderDal _salesOrderDal = new SalesOrderDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            dgw.DataSource = _productDal.GetAll();
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            bool isExist = _productDal.GetAll().Any(p => p.Name == name.Text);
            if (!isExist)
            {
                if (!InputValidator.ValidateDecimal(unitprice.Text, out decimal unitPrice)) return;
                if (!InputValidator.ValidateInt(stockamount.Text, out int stockAmount)) return;
                if (!InputValidator.ValidateInt(categoryid.Text, out int categoryId)) return;

                _productDal.Add(new Product
                {
                    Name = name.Text,
                    UnitPrice = unitPrice,
                    StockAmount = stockAmount,
                    ProductCategoryId = categoryId
                });
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Product already exists");
            }
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            var entity = _productDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgw.CurrentRow.Cells[0].Value));
            if (entity != null)
            {
                entity.Name = name.Text;
                if (!InputValidator.ValidateDecimal(unitprice.Text, out decimal unitPrice)) return;
                if (!InputValidator.ValidateInt(stockamount.Text, out int stockAmount)) return;
                if (!InputValidator.ValidateInt(categoryid.Text, out int categoryId)) return;

                entity.UnitPrice = unitPrice;
                entity.StockAmount = stockAmount;
                entity.ProductCategoryId = categoryId;
                _productDal.Update(entity);
                LoadProducts(); // Verileri yeniden yükle
            }
        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
            var productToDelete = new Product { Id = id };
            _productDal.Delete(productToDelete);
            LoadProducts(); // Verileri yeniden yükle
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
            stockamount.Text = dgw.CurrentRow.Cells[3].Value.ToString();
            categoryid.Text = dgw.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts(); // Form yüklendiğinde ürünleri yükle
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            var result = _productDal.Search(searchtext.Text);
            dgw.DataSource = result;
        }

        private void filtercategoryid_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateInt(categoryidvalue.Text, out int categoryId)) return;
            var result = _productDal.GetByCategoryId(id: categoryId);
            dgw.DataSource = result;
        }

        private void filterunitprice_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateDecimal(minprice.Text, out decimal minPrice)) return;
            if (!InputValidator.ValidateDecimal(maxprice.Text, out decimal maxPrice)) return;

            var result = _productDal.GetByUnitPrice(min: minPrice, max: maxPrice);
            dgw.DataSource = result;
        }

        private void filterstockamount_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateInt(minstock.Text, out int minStock)) return;
            if (!InputValidator.ValidateInt(maxstock.Text, out int maxStock)) return;

            var result = _productDal.GetByStockAmount(min: minStock, max: maxStock);
            dgw.DataSource = result;
        }

        private void orderforsupplier_Click(object sender, EventArgs e)
        {
            if (dgw.SelectedRows.Count > 0)
            {
                var productId = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
                var supplierId = Convert.ToInt32(supplierid.Text); // Tedarikçi ID'si

                // Örnek: 10 adet sipariş oluştur
                int quantity = 10;
                var product = _productDal.GetAll().FirstOrDefault(p => p.Id == productId);
                if (product != null)
                {
                    var totalPrice = product.UnitPrice * quantity;
                    var purchaseOrder = new PurchaseOrder
                    {
                        ProductId = productId,
                        SupplierId = supplierId,
                        Quantity = quantity,
                        TotalPrice = totalPrice,
                        OrderDate = DateTime.Now,
                        IsPaid = false
                    };
                    _purchaseOrderDal.Add(purchaseOrder);
                    MessageBox.Show("Purchase order created.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private void orderforcustomer_Click(object sender, EventArgs e)
        {
            if (dgw.SelectedRows.Count > 0)
            {
                var productId = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value);
                var customerId = Convert.ToInt32(customerid.Text); // Müşteri ID'si
                var quantity = Convert.ToInt32(quantity.Text); // Satılan miktar
                var isPaid = false; // Ödeme yapılmadı

                var product = _productDal.GetAll().FirstOrDefault(p => p.Id == productId);
                if (product != null && product.StockAmount >= quantity)
                {
                    var totalPrice = product.UnitPrice * quantity;
                    var salesOrder = new SalesOrder
                    {
                        ProductId = productId,
                        CustomerId = customerId,
                        Quantity = quantity,
                        TotalPrice = totalPrice,
                        OrderDate = DateTime.Now,
                        IsPaid = isPaid
                    };
                    _salesOrderDal.Add(salesOrder);

                    // Stok güncellemesi
                    product.StockAmount -= quantity;
                    _productDal.Update(product);

                    MessageBox.Show("Sales order created and stock updated.");
                }
                else
                {
                    MessageBox.Show("Insufficient stock or product not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private void showorders_Click(object sender, EventArgs e)
        {
            var purchaseOrders = _purchaseOrderDal.GetAll();
            var salesOrders = _salesOrderDal.GetAll();

            // Tedarikçi siparişlerini ve müşteri siparişlerini göstermek için DataGridView'ler oluşturulabilir
            // Örnek:
            var purchaseOrdersForm = new OrdersForm(purchaseOrders, salesOrders);
            purchaseOrdersForm.Show();
        }
    }
}

*/