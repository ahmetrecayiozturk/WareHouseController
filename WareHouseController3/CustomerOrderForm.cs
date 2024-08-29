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

namespace WareHouseController3
{
    public partial class CustomerOrderForm : Form
    {
        SalesOrderDal _salesOrderDal = new SalesOrderDal();
        ProductDal _productDal = new ProductDal();
        CustomerDal _customerDal = new CustomerDal();
        public CustomerOrderForm()
        {
            InitializeComponent();
            // SetupFormLayout();
        }
        /*
        private void SetupFormLayout()
        {
            // TableLayoutPanel oluşturun
            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 8
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // Row styles
            for (int i = 0; i < 7; i++)
            {
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            }
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Bileşenleri ekleyin
            layout.Controls.Add(new Label { Text = "Product Name:", Anchor = AnchorStyles.Right }, 0, 0);
            layout.Controls.Add(salesProductName, 1, 0);
            layout.Controls.Add(new Label { Text = "Customer Name:", Anchor = AnchorStyles.Right }, 0, 1);
            layout.Controls.Add(customerName, 1, 1);
            layout.Controls.Add(new Label { Text = "Quantity:", Anchor = AnchorStyles.Right }, 0, 2);
            layout.Controls.Add(salesQuantity, 1, 2);
            layout.Controls.Add(new Label { Text = "Total Price:", Anchor = AnchorStyles.Right }, 0, 3);
            layout.Controls.Add(salesTotalPrice, 1, 3);
            layout.Controls.Add(new Label { Text = "Order Date:", Anchor = AnchorStyles.Right }, 0, 4);
            layout.Controls.Add(salesOrderDate, 1, 4);
            layout.Controls.Add(new Label { Text = "Condition:", Anchor = AnchorStyles.Right }, 0, 5);
            layout.Controls.Add(salesCondition, 1, 5);
            layout.Controls.Add(new Label { Text = "Payment Condition:", Anchor = AnchorStyles.Right }, 0, 6);
            layout.Controls.Add(salesPaymentCondition, 1, 6);

            // Düğmeleri ekleyin
            layout.Controls.Add(addCustomerOrder, 0, 7);
            layout.Controls.Add(confirmOrderBtn, 1, 7);
            layout.Controls.Add(confirmBackConditionBtn, 1, 7); // Tek bir satıra yerleştirildi
            layout.Controls.Add(button3, 1, 7); // Tek bir satıra yerleştirildi
            layout.Controls.Add(button5, 1, 7); // Tek bir satıra yerleştirildi

            // TableLayoutPanel'i form'a ekleyin
            this.Controls.Add(layout);
        }
        */
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

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            salesProductName.Text = dgwSalesOrder.CurrentRow.Cells[1].Value.ToString();
            customerName.Text = dgwSalesOrder.CurrentRow.Cells[2].Value.ToString();
            salesQuantity.Text = dgwSalesOrder.CurrentRow.Cells[5].Value.ToString();
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == salesProductName.Text);
            salesOrderDate.Text = dgwSalesOrder.CurrentRow.Cells[7].Value.ToString();
            salesCondition.Text = dgwSalesOrder.CurrentRow.Cells[8].Value.ToString();
            salesPaymentCondition.Text = dgwSalesOrder.CurrentRow.Cells[8].Value.ToString();
            LoadProducts();
        }

        private void addCustomerOrder_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(salesProductName.Text.ToLower(), out string salesproductname)) return;
            if (!InputValidator.ValidateString(customerName.Text.ToLower(), out string customername)) return;
            if (!InputValidator.ValidateInt(salesQuantity.Text.ToLower(), out int quantity)) return;
            if (!InputValidator.ValidateDateTime(salesOrderDate.Text.ToLower(), out DateTime orderdate)) return;
            if (!InputValidator.ValidateBoolean(salesCondition.Text.ToLower(), out bool paidcondition)) return;

            var customer = _customerDal.GetAll().FirstOrDefault(p => p.Name == customername);
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == salesproductname);
            if (product == null)
            {
                MessageBox.Show("Product not found");
                return;
            }
            var tottalprice = product.UnitPrice * quantity;
            if(product.StockAmount < quantity)
            {
                MessageBox.Show("There is not enough stock");
                return;
            }
            if (customer == null)
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
            if(quantity == 0)
            {
                MessageBox.Show("Quantity can't be zero");
                return;
            }
            if (orderdate > DateTime.Now)
            {
                MessageBox.Show("Order date can't be in the future");
                return;
            }

            _salesOrderDal.AddNew(new SalesOrder
            {
                ProductName = salesproductname,
                CustomerName = customername,
                CustomerAddress = customer.Address,
                CustomerContact = customer.ContactInfo,
                Quantity = quantity,
                TotalPrice = tottalprice,
                OrderDate = orderdate,
                IsPaid = paidcondition
            });
            /*
            // Bu işlemi order confirm olduğunda yapmak daha mantıklı
            var entity = _productDal.GetAll().FirstOrDefault(p => p.Name == salesproductname);
            entity.StockAmount -= quantity;
            _productDal.Update(entity);
            */
            Form1 form1 = new Form1();
            form1.LoadProducts();
            LoadProducts();
            MessageBox.Show("Order is added");
        }

        private void salesPaymentCondition_TextChanged(object sender, EventArgs e)
        {

        }
        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderConfirmText.Text.ToLower() == "understand")
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
                    MessageBox.Show("Order is paid now");
                }
            }
            else
            {
                MessageBox.Show("Please enter the 'understand' word to confirm the order");
            }
        }

        private void confirmBackConditionBtn_Click(object sender, EventArgs e)
        {
            if (confirmBackCondition.Text.ToLower() == "understand")
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
                    MessageBox.Show("Order is unpaid now");
                }
            }
            else
            {
                MessageBox.Show("Please enter the 'understand' word to confirm the order");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var entity = _salesOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
            var product = _productDal.GetAll().FirstOrDefault(p => p.Name == salesProductName.Text);
            var totallprice = product.UnitPrice * Convert.ToInt32(salesQuantity.Text);
            var customer = _customerDal.GetAll().FirstOrDefault(p => p.Name == customerName.Text);

            if (entity != null)
            {
                if (!InputValidator.ValidateString(salesProductName.Text.ToLower(), out string salesproductname)) return;
                if (!InputValidator.ValidateString(customerName.Text.ToLower(), out string customername)) return;
                if (!InputValidator.ValidateInt(salesQuantity.Text.ToLower(), out int quantity)) return;
                if (!InputValidator.ValidateDateTime(salesOrderDate.Text.ToLower(), out DateTime orderdate)) return;
                if (!InputValidator.ValidateBoolean(salesCondition.Text.ToLower(), out bool paidcondition)) return;
              
                entity.ProductName = salesproductname;
                entity.CustomerName = customername;
                entity.CustomerAddress = customer.Address;
                entity.CustomerContact = customer.ContactInfo;
                entity.Quantity = quantity;
                entity.TotalPrice = totallprice;
                entity.OrderDate = orderdate;
                entity.IsPaid = paidcondition;
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
                if (customer == null)
                {
                    MessageBox.Show("Customer not found");
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
                _salesOrderDal.Update(entity);
               
                LoadProducts();
                MessageBox.Show("Order is updated");
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
                MessageBox.Show("Order is deleted");
            }
        }

        private void searchCustomerName_TextChanged(object sender, EventArgs e)
        {
            using(var context = new WareHouseControlContext())
            {
                var result = context.SalesOrders.Where(p => p.CustomerName.Contains(searchCustomerName.Text)).ToList();
                dgwSalesOrder.DataSource = result;
            }
        }

        private void showAllOrders_Click(object sender, EventArgs e)
        {
            using(var context = new WareHouseControlContext())
            {
                var result = context.SalesOrders.ToList();
                dgwSalesOrder.DataSource = result;
            }
        }

        private void showUnpaidOrders_Click(object sender, EventArgs e)
        {
            using (var context = new WareHouseControlContext())
            {
                var result = context.SalesOrders.Where(p => p.IsPaid == false).ToList();
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
    }

}