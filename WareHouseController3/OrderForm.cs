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
            MessageBox.Show("Sales order marked as paid.");
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
                MessageBox.Show("Purchase order created successfully.");
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

        private void button3_Click(object sender, EventArgs e)
        {
            var entity = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == entity.ProductName);
            var supplier = _supplierDal.GetAll().FirstOrDefault(p => p.Name == entity.SupplierName);
            //var price = product.UnitPrice;
            var totalprice = product.UnitPrice * Convert.ToInt32(productQuantity.Text);
            if (!InputValidator.ValidateString(productName.Text, out string productname)) return;
            if (!InputValidator.ValidateString(supplierName.Text, out string suppliername)) return;
            if (!InputValidator.ValidateInt(productQuantity.Text, out int quantity)) return;
            if (!InputValidator.ValidateDateTime(supplierDate.Text, out DateTime orderdate)) return;
            if (!InputValidator.ValidateBoolean(IsDelivered.Text, out bool paidcondition)) return;
            if (entity != null)
            {
                entity.ProductName = productname;
                entity.SupplierName = suppliername;
                entity.Quantity = quantity;
                entity.TotalPrice = totalprice;
                entity.OrderDate = orderdate;
                entity.IsPaid = paidcondition;
                _purchaseOrderDal.Update(entity);
                if (product == null)
                {
                    MessageBox.Show("Product not found");
                    return;
                }
                if (product.StockAmount < quantity)
                {
                    MessageBox.Show("There is not enough stock");
                    return;
                }
                if (supplier == null)
                {
                    MessageBox.Show("Supplier not found");
                    return;
                }
                if (entity.IsPaid == true)
                {
                    MessageBox.Show("You can't update a paid order");
                    return;
                }
                if (entity.Quantity < 0)
                {
                    MessageBox.Show("Quantity can't be negative");
                    return;
                }
                if (entity.TotalPrice < 0)
                {
                    MessageBox.Show("Total price can't be negative");
                    return;
                }
                if (entity.OrderDate > DateTime.Now)
                {
                    MessageBox.Show("Order date can't be in the future");
                    return;
                }
                LoadOrders();
                MessageBox.Show("Order updated");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwSalesOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productName.Text = dgwSalesOrder.CurrentRow.Cells[1].Value.ToString();
            supplierName.Text = dgwSalesOrder.CurrentRow.Cells[2].Value.ToString();
            productQuantity.Text = dgwSalesOrder.CurrentRow.Cells[5].Value.ToString();
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == productName.Text);
            supplierDate.Text = dgwSalesOrder.CurrentRow.Cells[7].Value.ToString();
            IsDelivered.Text = dgwSalesOrder.CurrentRow.Cells[8].Value.ToString();
            purchasePaymentCondition.Text = dgwSalesOrder.CurrentRow.Cells[8].Value.ToString();
            LoadOrders();
        }

        private void addSupplierOrder_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(productName.Text.ToLower(), out string productname)) return;
            if (!InputValidator.ValidateString(supplierName.Text.ToLower(), out string suppliername)) return;
            if (!InputValidator.ValidateInt(productQuantity.Text.ToLower(), out int quantity)) return;
            if (!InputValidator.ValidateDateTime(supplierDate.Text.ToLower(), out DateTime orderdate)) return;
            if (!InputValidator.ValidateBoolean(IsDelivered.Text.ToLower(), out bool paidcondition)) return;

            var supplier = _supplierDal.GetAll().FirstOrDefault(p => p.Name == suppliername);
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == productname);
            if (product == null)
            {
                MessageBox.Show("Product not found");
                return;
            }
            var tottalprice = product.UnitPrice * quantity;
            if (product.StockAmount < quantity)
            {
                MessageBox.Show("There is not enough stock");
                return;
            }
            if (supplier == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }
            if (product == null)
            {
                MessageBox.Show("Product not found");
                return;
            }
            if (quantity < 0)
            {
                MessageBox.Show("Quantity can't be negative");
                return;
            }
            if (quantity == 0)
            {
                MessageBox.Show("Quantity can't be zero");
                return;
            }
            if (orderdate > DateTime.Now)
            {
                MessageBox.Show("Order date can't be in the future");
                return;
            }
            _purchaseOrderDal.AddNew(new PurchaseOrder
            {
                ProductName = productname,
                SupplierName = suppliername,
                Address = supplier.Address,
                ContactInfo = supplier.ContactInfo,
                Quantity = quantity,
                TotalPrice = tottalprice,
                OrderDate = orderdate,
                IsPaid = paidcondition
            });
            
            LoadOrders();
            MessageBox.Show("Order added");
            /*
            if (paidcondition == true)
            {
                var entity1 = _productDal.GetAll().FirstOrDefault(p => p.Name == productname);
                entity1.StockAmount += quantity;
                _productDal.Update(entity1);
            }
            //Burası İsDelivery==true ise stokta arttırma işlemi yapılacak
            if (paidcondition == true)
            {
                var entity1 = _productDal.GetAll().FirstOrDefault(p => p.Name == productname);
                entity1.StockAmount += quantity;
                _productDal.Update(entity1);
            }
            var entity = _productDal.GetAll().FirstOrDefault(p => p.Name == productname);
            entity.StockAmount -= quantity;
            _productDal.Update(entity);
            Form1 form1 = new Form1();
            form1.LoadProducts();
            LoadOrders();
            */

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(addSupplierName.Text.ToLower(), out string suppliername)) return;
            if (!InputValidator.ValidateString(addSupplierContact.Text.ToLower(), out string suppliercontact)) return;
            if (!InputValidator.ValidateString(supplierAddress.Text.ToLower(), out string supplieraddress)) return;
            _supplierDal.AddNew(new Supplier{
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
                if(entity.IsPaid == true)
                {
                    product.StockAmount -= entity.Quantity;
                    _productDal.Update(product);
                }
                _productDal.Update(product);
                LoadOrders();
                MessageBox.Show("Order deleted");
            }
        }

        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderConfirmText.Text.ToLower() == "understand")
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
                    MessageBox.Show("Order Delivered");
                }
            }
            else
            {
                MessageBox.Show("Please enter the 'understand' word to confirm the order");
            }
            /*
            string confirmText = orderConfirmText.Text.ToLower();
            var purchaseOrder = _purchaseOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
            if (confirmText == "understand")
            {
                purchaseOrder.IsPaid = true;
                MessageBox.Show("Order confirmed");
            }
            else
            {
                MessageBox.Show("Order not confirmed, please text 'understand' correctly");
            }
            */
        }

        private void confirmBackConditionBtn_Click(object sender, EventArgs e)
        {
            if (orderConfirmText3.Text.ToLower() == "understand")
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
                    MessageBox.Show("Taking Back of  Delivering Order Confirmed");
                }
            }
            else
            {
                MessageBox.Show("Please enter the 'understand' word to confirm the order");
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
            using(var context = new WareHouseControlContext())
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
    }
}
