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

        private void LoadProducts()
        {
            dgw.DataSource = _productDal.GetAll();
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            bool isExist = _productDal.GetAll().Any(p => p.Name == name.Text);
            if (!isExist)
            {
                _productDal.Add(new Product
                {
                    Name = name.Text,
                    UnitPrice = Convert.ToDecimal(unitprice.Text),
                    StockAmount = Convert.ToInt32(stockamount.Text),
                    ProductCategoryId = Convert.ToInt32(categoryid.Text)
                });
                LoadProducts(); // Verileri yeniden yükle
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
                entity.UnitPrice = Convert.ToDecimal(unitprice.Text);
                entity.StockAmount = Convert.ToInt32(stockamount.Text);
                entity.ProductCategoryId = Convert.ToInt32(categoryid.Text);
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
            
            int categoryId;
            if (int.TryParse(categoryidvalue.Text, out categoryId))
            {
                var result = _productDal.GetByCategoryId(id: categoryId);
                dgw.DataSource = result;
            }
            else
            {
                MessageBox.Show("Please enter a valid category id.");
            }
            
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
            decimal minPrice, maxPrice;
            if (decimal.TryParse(minprice.Text, out minPrice) && decimal.TryParse(maxprice.Text, out maxPrice))
            {
                var result = _productDal.GetByUnitPrice(min: minPrice, max: maxPrice);
                dgw.DataSource = result;
            }
            else
            {
                MessageBox.Show("Please enter valid decimal numbers for the price range.");
            }
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
            int minStock, maxStock;

            if (int.TryParse(minstock.Text, out minStock) && int.TryParse(maxstock.Text, out maxStock))
            {
                var result = _productDal.GetByStockAmount(min: minStock, max: maxStock);
                dgw.DataSource = result;
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for stock amounts.");
            }
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
                _productDal.Add(new Product
                {
                    Name = name.Text,
                    UnitPrice = Convert.ToDecimal(unitprice.Text),
                    StockAmount = Convert.ToInt32(stockamount.Text)
                });
                LoadProducts(); // Verileri yeniden yükle
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
                entity.UnitPrice = Convert.ToDecimal(unitprice.Text);
                entity.StockAmount = Convert.ToInt32(stockamount.Text);
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
        //buradan sonrası gereksiz
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
        WareHouseControlContext context = new WareHouseControlContext();
        ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            using (context)
            {
                dgw.DataSource = context.Products.ToList();
            }
        }
        private void addproduct_Click(object sender, EventArgs e)
        {
            using (context)
            {
                bool isexist = context.Products.Any(p => p.Name == name.Text);
                if (!isexist){
                    _productDal.Add(new Product{
                        Name = name.Text,
                        UnitPrice = Convert.ToDecimal(unitprice.Text),
                        StockAmount = Convert.ToInt32(stockamount.Text)
                    });
                    dgw.DataSource = context.Products.ToList();
                }
                else{
                    MessageBox.Show("Product already exists");
                }
            }
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            using(context)
            {
                var entity = context.Products.Find(Convert.ToInt32(dgw.CurrentRow.Cells[0].Value));
                entity.Name = name.Text;
                entity.UnitPrice = Convert.ToDecimal(unitprice.Text);
                entity.StockAmount = Convert.ToInt32(stockamount.Text);
                _productDal.Update(entity);
                dgw.DataSource = context.Products.ToList();
            }
        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            using(context){ 
                _productDal.Delete(new Product{
                    Id = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value)
                });
            }
        }

        private void searchproduct_Click(object sender, EventArgs e)
        {

        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using(context)
            {
                name.Text = dgw.CurrentRow.Cells[1].Value.ToString();
                unitprice.Text = dgw.CurrentRow.Cells[2].Value.ToString();
                stockamount.Text = dgw.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                dgw.DataSource = _productDal.GetAll();
            
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            _productDal.Search(searchtext.Text);

        }
    }
}
*/