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
        public CustomerOrderForm()
        {
            InitializeComponent();
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
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            salesProductName.Text = dgwSalesOrder.CurrentRow.Cells[1].Value.ToString();
            customerName.Text = dgwSalesOrder.CurrentRow.Cells[2].Value.ToString();
            salesQuantity.Text = dgwSalesOrder.CurrentRow.Cells[3].Value.ToString();
            salesTotalPrice.Text = dgwSalesOrder.CurrentRow.Cells[4].Value.ToString();
            salesOrderDate.Text = dgwSalesOrder.CurrentRow.Cells[5].Value.ToString();
            salesCondition.Text = dgwSalesOrder.CurrentRow.Cells[6].Value.ToString();
            salesPaymentCondition.Text = dgwSalesOrder.CurrentRow.Cells[6].Value.ToString();
            LoadProducts();
        }

        private void addCustomerOrder_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(salesProductName.Text, out string salesproductname)) return;
            if (!InputValidator.ValidateString(customerName.Text, out string customername)) return;
            if (!InputValidator.ValidateInt(salesQuantity.Text, out int quantity)) return;
            if (!InputValidator.ValidateDecimal(salesTotalPrice.Text, out decimal totalprice)) return;
            if (!InputValidator.ValidateDateTime(salesOrderDate.Text, out DateTime orderdate)) return;
            if (!InputValidator.ValidateBoolean(salesCondition.Text, out bool paidcondition)) return;
            _salesOrderDal.AddNew(new SalesOrder
            {
                ProductName = salesproductname,
                CustomerName = customername,
                Quantity = quantity,
                TotalPrice = totalprice,
                OrderDate = orderdate,
                IsPaid = paidcondition
            });
            LoadProducts();
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

                if (entity != null)
                {
                    entity.IsPaid = true;
                    _salesOrderDal.Update(entity); // Veritabanında güncelleme yapın
                    LoadProducts(); // Verileri yeniden yükleyin
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

                if (entity != null)
                {
                    entity.IsPaid = false;
                    _salesOrderDal.Update(entity); // Veritabanında güncelleme yapın
                    LoadProducts(); // Verileri yeniden yükleyin
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
            if (entity != null)
            {
                if (!InputValidator.ValidateString(salesProductName.Text, out string salesproductname)) return;
                if (!InputValidator.ValidateString(customerName.Text, out string customername)) return;
                if (!InputValidator.ValidateInt(salesQuantity.Text, out int quantity)) return;
                if (!InputValidator.ValidateDecimal(salesTotalPrice.Text, out decimal totalprice)) return;
                if (!InputValidator.ValidateDateTime(salesOrderDate.Text, out DateTime orderdate)) return;
                if (!InputValidator.ValidateBoolean(salesCondition.Text, out bool paidcondition)) return;
              
                entity.ProductName = salesproductname;
                entity.CustomerName = customername;
                entity.Quantity = quantity;
                entity.TotalPrice = totalprice;
                entity.OrderDate = orderdate;
                entity.IsPaid = paidcondition;
                _salesOrderDal.Update(entity);
               
                LoadProducts();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var entity = _salesOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
            if (entity != null)
            {
                _salesOrderDal.Delete(entity);
                LoadProducts();
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
    }

    /*
    private void confirmOrderBtn_Click(object sender, EventArgs e)
    {
        if (orderConfirmText.Text.ToLower() == "understand") 
        {
            var entity = _salesOrderDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dgwSalesOrder.CurrentRow.Cells[0].Value));
            entity.IsPaid = true;
            LoadProducts(); } 
        else 
        { 
            MessageBox.Show("Please enter the 'understand' word to confirm the order");
            LoadProducts();

        }
    }*/
}

