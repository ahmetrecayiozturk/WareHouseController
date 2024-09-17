using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class MonthlyProfit : Form
    {
        private SalesOrderDal _salesOrderDal = new SalesOrderDal();
        private ProductDal _productDal = new ProductDal(); // Ürünlerin verilerini almak için

        public MonthlyProfit()
        {
            InitializeComponent();
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }
        private void LoadMonthlySales(DateTime date)
        {
            // Seçilen ay ve yıl için satışları al
            var salesOrders = _salesOrderDal.GetAll()
                .Where(o => o.OrderDate.Year == date.Year && o.OrderDate.Month == date.Month)
                .ToList();

            var products = _productDal.GetAll().ToList();
            var salesSummary = from so in salesOrders
                               join p in products on so.ProductName equals p.Name // Ürün isimlerine göre eşleştirme
                               group new { so, p } by so.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   TotalQuantity = g.Sum(x => x.so.Quantity),
                                   TotalPrice = g.Sum(x => x.so.TotalPrice),
                                   NetProfit = g.Sum(x => x.so.Quantity * (x.p.UnitPrice - x.p.PurchasePrice)) // Net kâr
                               };
            // DataGridView'e satış özetini yükleyin
            dataGridView1.DataSource = salesSummary.ToList();

            // Toplam karı hesaplayın
            var totalProfit = salesSummary.Sum(x => x.TotalPrice);
            var monthlyProfit = salesSummary.ToDictionary(x => x.ProductName, x => x.TotalPrice);

            // Toplam karı ve ürün başına karı gösterin
            label1.Text = $"BU TARİH {date:MMMM yyyy} İÇİN KAR: {totalProfit:C}";

            listBox1.Items.Clear();
            foreach (var item in monthlyProfit)
            {
                listBox1.Items.Add($"{item.Key}: {item.Value:C}");
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["ProductName"].HeaderText = "Ürün İsim";
            dataGridView1.Columns["TotalQuantity"].HeaderText = "Toplam Miktar";
            dataGridView1.Columns["TotalPrice"].HeaderText = "Brüt Kar";
            dataGridView1.Columns["NetProfit"].HeaderText = "Net Kar";
        }

        private void MonthlyProfit_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMonthlySales(monthCalendar1.SelectionStart);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form VeresiyeAylıkKar = new VeresiyeAylıkKar();
            VeresiyeAylıkKar.Show();
        }
    }
}


/*
 * 
            var salesSummary = from so in salesOrders
                               group so by so.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   TotalQuantity = g.Sum(x => x.Quantity),
                                   TotalPrice = g.Sum(x => x.TotalPrice)

                               };
 
 
 * 





namespace WareHouseController3
{
    public partial class MonthlySalesForm : Form
    {
        private SalesOrderDal _salesOrderDal = new SalesOrderDal();
        private ProductDal _productDal = new ProductDal(); // Ürünlerin verilerini almak için

        public MonthlySalesForm()
        {
            InitializeComponent();
        }

        private void MonthlySalesForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde gerekli işlemler yapılabilir
        }

        private void LoadMonthlySales(DateTime date)
        {
            // Seçilen ay ve yıl için satışları al
            var salesOrders = _salesOrderDal.GetAll()
                .Where(o => o.OrderDate.Year == date.Year && o.OrderDate.Month == date.Month)
                .ToList();

            var products = _productDal.GetAll().ToList();
            var salesSummary = from so in salesOrders
                               group so by so.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   TotalQuantity = g.Sum(x => x.Quantity),
                                   TotalPrice = g.Sum(x => x.TotalPrice)
                               };

            // DataGridView'e satış özetini yükleyin
            dataGridView1.DataSource = salesSummary.ToList();

            // Toplam karı hesaplayın
            var totalProfit = salesSummary.Sum(x => x.TotalPrice);
            var monthlyProfit = salesSummary.ToDictionary(x => x.ProductName, x => x.TotalPrice);

            // Toplam karı ve ürün başına karı gösterin
            totalProfitLabel.Text = $"Total Profit for {date:MMMM yyyy}: {totalProfit:C}";
            
            productProfitListBox.Items.Clear();
            foreach (var item in monthlyProfit)
            {
                productProfitListBox.Items.Add($"{item.Key}: {item.Value:C}");
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // Butona tıklandığında DateTimePicker'dan seçilen ayı kullanarak verileri yükle
            LoadMonthlySales(dateTimePicker.Value);
        }
    }
} 
*/