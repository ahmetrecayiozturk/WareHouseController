using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    // This class is used to add, delete, update, or perform different operations on products in the database
    internal class ProductDal
    {
        // Add a product to the database
        public void Add(Product product)
        {
            using (var context = new WareHouseControlContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                MessageBox.Show("Product Added");
            }
        }

        // Get all products from the database
        public List<Product> GetAll()
        {
            using (var context = new WareHouseControlContext())
            {
                return context.Products.ToList();
            }
        }

        // Update an existing product in the database
        public void Update(Product product)
        {
            using (var context = new WareHouseControlContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Product Updated");
            }
        }

        // Delete a product from the database
        public void Delete(Product product)
        {
            using (var context = new WareHouseControlContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                MessageBox.Show("Product Deleted");
            }
        }

        // Search for products by name in the database
        public List<Product> Search(string key)
        {
            using (var context = new WareHouseControlContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }
    }
}

/*
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