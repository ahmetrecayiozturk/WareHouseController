using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    //We create a context class that inherits from DbContext class, this is use for entity

    public class WareHouseControlContext : DbContext
    {
        // Constructor to configure automatic migrations
        public WareHouseControlContext() : base("name=WareHouseDb")
        {
            // Automatically apply migrations to the latest version
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WareHouseControlContext, Migrations.Configuration>());
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<Profit> Profits { get; set; }
    }
}
