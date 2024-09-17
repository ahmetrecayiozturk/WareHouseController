using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class VeresiyeAylıkKar : Form
    {
        ProductDal _productDal = new ProductDal();
        SalesOrderDal _salesOrderDal = new SalesOrderDal();
        ProfitDal _profitDal = new ProfitDal();
        public VeresiyeAylıkKar()
        {
            InitializeComponent();
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalProfitLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }
        private void LoadProfits(DateTime date)
        {
            var profits = _profitDal.GetAll()
              .Where(o => o.PaidDate.Year == date.Year && o.PaidDate.Month == date.Month)
              .ToList();

            var products = _productDal.GetAll().ToList();

            // Ürünleri SalesOrder ile ilişkilendiriyoruz
            /*
            var salesSummary = from so in profits
                               join p in products on so.ProductName equals p.Name // Ürün isimlerine göre eşleştirme
                               group new { so, p } by so.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   UnitPrice = g.Sum(x => x.so.UnitPrice),
                                   PurchasePrice = g.Sum(x => x.so.PurchasePrice),
                                   PaidDate = date,
                                   PaidAmount = g.Sum(x => x.so.PaidAmount),
                                   NetProfit = (g.Sum(x => x.so.PaidAmount))*(g.Sum(x => x.so.UnitPrice - x.so.PurchasePrice)/g.Sum(x => x.so.UnitPrice)) // Net kâr
                               };
            */
            var salesSummary = from so in profits
                               join p in products on so.ProductName equals p.Name
                               group new { so, p } by so.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   UnitPrice = g.Sum(x => x.so.UnitPrice),
                                   PurchasePrice = g.Sum(x => x.so.PurchasePrice),
                                   PaidDate = date,
                                   PaidAmount = g.Sum(x => x.so.PaidAmount),
                                   NetProfit = g.Sum(x => x.so.UnitPrice) != 0
                                               ? (g.Sum(x => x.so.PaidAmount)) * (g.Sum(x => x.so.UnitPrice - x.so.PurchasePrice) / g.Sum(x => x.so.UnitPrice))
                                               : 0 // Avoid division by zero
                               };

            dataGridView1.DataSource = salesSummary.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["ProductName"].HeaderText = "Ürün İsim";
            dataGridView1.Columns["UnitPrice"].HeaderText = "Ürün Fiyatı";
            dataGridView1.Columns["PurchasePrice"].HeaderText = "Alış Fiyatı";
            dataGridView1.Columns["PaidDate"].HeaderText = "Ödeme Tarihi";
            dataGridView1.Columns["PaidAmount"].HeaderText = "Ödenen Fiyatı";
            dataGridView1.Columns["NetProfit"].HeaderText = "Stok Miktarı";

            var totalProfit = salesSummary.Sum(x => x.PaidAmount); // Tüm brüt kâr
            var netProfit = salesSummary.Sum(x => x.NetProfit);    // Tüm net kâr

            var dailyGrossProfit = salesSummary.ToDictionary(x => x.ProductName, x => x.PaidAmount);
            var dailyNetProfit = salesSummary.ToDictionary(x => x.ProductName, x => x.NetProfit);
            listBox1.Items.Clear();
            foreach (var item in dailyGrossProfit)
            {
                listBox1.Items.Add($"{item.Key} - Brüt Kar: {item.Value:C} - Net Kar: {dailyNetProfit[item.Key]:C}");
            }

            totalProfitLabel.Text = $"Toplam Aylık Brüt Kar: {totalProfit:C} - Aylık Net Kar: {netProfit:C}";
        }

        private void monthCalendar1SelectionChanged(object sender, EventArgs e)
        {
            LoadProfits(monthCalendar1.SelectionStart);
        }
        private void VeresiyeAylıkKar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadProfits(monthCalendar1.SelectionStart);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            LoadProfits(monthCalendar1.SelectionStart);

        }
    }
}
