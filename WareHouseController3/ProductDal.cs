using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    // Product işlemleri için sınıf, CrudGenerics'ten türetilmiş
    // Burada Product sınıfı ile ilgili işlemler yapılır
    // Productdal sınıfı CrudGenerics sınıfından türetilmiştir ve bu sınıfın özelliklerini kullanır
    // Örneğin Add, Update, Delete, GetAll gibi
    // Fakat ayrıca Search metodu eklenmiştir, bunu CrudGenerics sınıfında bulamayız
    // Bu search metodu Product sınıfı ile ilgili özel bir işlem olduğu için ProductDal sınıfına eklenmiştir
    // Bunu gibi başka özel işlemler de eklenebilir, temel metodlar CrudGenerics sınıfında bulunur
    // Özel metodlar ise ProductDal sınıfı gibi ayrı sınıflarda tanımlanır
    internal class ProductDal : CrudGenerics<Product>
    {
        // Ürün arama işlemi
        public List<Product> Search(string key)
        {
            using (var context = new WareHouseControlContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (var context = new WareHouseControlContext())
            {

                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
                //return context.Products.Where(p => p.UnitPrice == product.UnitPrice).ToList();
            }
        }
        public List<Product> GetByStockAmount(int min, int max) {
            using (var context = new WareHouseControlContext())
            {

                return context.Products.Where(p => p.StockAmount >= min && p.StockAmount < max).ToList();
                //return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }
        /*
        public List<Product> GetByCategoryId(int id)
        {
            using(var context = new WareHouseControlContext())
            {
                return context.Products.Where(p => p.ProductCategoryId == id).ToList();
            }
        }
        */
    }
}

/* çalışankod1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseController3;
internal class ProductDal
{
    public void Add(Product product)
    {
        using (var context = new WareHouseControlContext())
        {
            context.Products.Add(product);
            MessageBox.Show("Product Added");
            context.SaveChanges();
        }
    }

    public List<Product> GetAll()
    {
        using (var context = new WareHouseControlContext())
        {
            return context.Products.ToList();
        }
    }

    public void Update(Product product)
    {
        using (var context = new WareHouseControlContext())
        {
            var entity = context.Entry(product);
            entity.State = System.Data.Entity.EntityState.Modified;
            MessageBox.Show("Product Updated");
            context.SaveChanges();
        }
    }

    public void Delete(Product product)
    {
        using (var context = new WareHouseControlContext())
        {
            var entity = context.Entry(product);
            entity.State = System.Data.Entity.EntityState.Deleted;
            MessageBox.Show("Product Deleted");
            context.SaveChanges();
        }
    }

    public List<Product> Search(string key)
    {
        using (var context = new WareHouseControlContext())
        {
            return context.Products.Where(p => p.Name.Contains(key)).ToList();
        }
    }
}


namespace WareHouseController3
{
    //This class is used to add delete update or different things to products to the database
    internal class ProductDal
    {
        WareHouseControlContext context = new WareHouseControlContext();
        public void Add(Product product)
        {
            using (context)
            {
                context.Products.Add(product);
                MessageBox.Show("Product Added");
                context.SaveChanges();
            }
        }
        public List<Product> GetAll()
        {
            using (context)
            {
                return context.Products.ToList();
            }
        }
        public void Update(Product product)
        {
            using (context)
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                MessageBox.Show("Product Updated");
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (context)
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                MessageBox.Show("Product Deleted");
                context.SaveChanges();
            }
        }
        public void Search(string key)
        {
            using (context)
            {
                var result = context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }
    }
}
*/