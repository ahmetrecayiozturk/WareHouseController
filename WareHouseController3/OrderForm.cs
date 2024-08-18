using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class OrderForm : Form
    {
        private readonly SalesOrderDal _salesOrderDal = new SalesOrderDal();
        private readonly PurchaseOrderDal _purchaseOrderDal = new PurchaseOrderDal();
        ProductDal _productDal = new ProductDal();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void LoadOrders()
        {
            var unpaidSalesOrders = _salesOrderDal.GetUnpaidOrders();
            var unpaidPurchaseOrders = _purchaseOrderDal.GetUnpaidOrders();

            // Tabloya veya listbox'a veri yükleyin
            // Örneğin: salesOrdersDataGridView.DataSource = unpaidSalesOrders;
            // Örneğin: purchaseOrdersDataGridView.DataSource = unpaidPurchaseOrders;
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
    }
}
