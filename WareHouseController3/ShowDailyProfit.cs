using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class ShowDailyProfit : Form
    {
        private SalesOrderDal _salesOrderDal = new SalesOrderDal();
        private ProductDal _productDal = new ProductDal(); // Ürünlerin verilerini almak için

        public ShowDailyProfit()
        {
            InitializeComponent();
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            veresiyekar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            productProfitListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalProfitLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void ShowDailyProfit_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde gerekli işlemler yapılabilir

        }

        private void calendarSelectionChanged(object sender, EventArgs e)
        {
            // Takvimden tarih seçildiğinde verileri yükle
            LoadDailySales(calendar.SelectionStart);
        }

        private void LoadDailySales(DateTime date)
        {
            var salesOrders = _salesOrderDal.GetAll()
                .Where(o => o.OrderDate.Date == date.Date && o.IsPaid == true)
                .ToList();

            var products = _productDal.GetAll().ToList();

            // Ürünleri SalesOrder ile ilişkilendiriyoruz
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

            dataGridView1.DataSource = salesSummary.ToList();
            dataGridView1.Columns["ProductName"].HeaderText = "Ürün İsim";
            dataGridView1.Columns["TotalQuantity"].HeaderText = "Toplam Miktar";
            dataGridView1.Columns["TotalPrice"].HeaderText = "Brüt Kar";
            dataGridView1.Columns["NetProfit"].HeaderText = "Net Kar";
            
            var totalGrossProfit = salesSummary.Sum(x => x.TotalPrice); // Tüm brüt kâr
            var totalNetProfit = salesSummary.Sum(x => x.NetProfit);    // Tüm net kâr
            var dailyGrossProfit = salesSummary.ToDictionary(x => x.ProductName, x => x.TotalPrice);
            var dailyNetProfit = salesSummary.ToDictionary(x => x.ProductName, x => x.NetProfit);

            totalProfitLabel.Text = $"Toplam Günlük Brüt Kar: {totalGrossProfit:C} - Net Kar: {totalNetProfit:C}";

            productProfitListBox.Items.Clear();
            foreach (var item in dailyGrossProfit)
            {
                productProfitListBox.Items.Add($"{item.Key} - Brüt Kar: {item.Value:C} - Net Kar: {dailyNetProfit[item.Key]:C}");
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            LoadDailySales(calendar.SelectionStart);
        }

        private void calendar_DateChanged(object sender, EventArgs e)
        {
            LoadDailySales(calendar.SelectionStart);
        }

        private void productProfitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalProfitLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void veresiyekar_Click(object sender, EventArgs e)
        {
            Form VeresiyeKar = new VeresiyeKar();
            VeresiyeKar.Show();
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class ShowDailyProfit : Form
    {
        private SalesOrderDal _salesOrderDal = new SalesOrderDal();
        private ProductDal _productDal = new ProductDal(); // Ürünlerin verilerini almak için

        public ShowDailyProfit()
        {
            InitializeComponent();
        }

        private void ShowDailyProfit_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde gerekli işlemler yapılabilir
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void calendarSelectionChanged(object sender, EventArgs e)
        {
            // Takvimden tarih seçildiğinde verileri yükle
            LoadDailySales(calendar.SelectionStart);
        }

        private void LoadDailySales(DateTime date)
        {
            var salesOrders = _salesOrderDal.GetAll()
                .Where(o => o.OrderDate.Date == date.Date)
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

            dataGridView1.DataSource = salesSummary.ToList();

            var totalProfit = salesSummary.Sum(x => x.TotalPrice);
            var dailyProfit = salesSummary.ToDictionary(x => x.ProductName, x => x.TotalPrice);

            totalProfitLabel.Text = $"TOPLAM GÜNLÜK KAR: {totalProfit:C}";
            // Ürün başına karları göstermek için:
            productProfitListBox.Items.Clear();
            foreach (var item in dailyProfit)
            {
                productProfitListBox.Items.Add($"{item.Key}: {item.Value:C}");
            }
        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            LoadDailySales(calendar.SelectionStart);

        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadDailySales(calendar.SelectionStart);

        }

        private void productProfitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalProfitLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
*/





/*
namespace WareHouseController3
{
    public partial class ShowDailyProfit : Form
    {
        public ShowDailyProfit()
        {
            InitializeComponent();
        }

        private void ShowDailyProfit_Load(object sender, EventArgs e)
        {

        }
    }
}
*/