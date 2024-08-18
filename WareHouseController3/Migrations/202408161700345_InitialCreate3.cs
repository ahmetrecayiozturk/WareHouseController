namespace WareHouseController3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseOrders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PurchaseOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SalesOrders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.SalesOrders", "ProductId", "dbo.Products");
            DropIndex("dbo.PurchaseOrders", new[] { "ProductId" });
            DropIndex("dbo.PurchaseOrders", new[] { "SupplierId" });
            DropIndex("dbo.SalesOrders", new[] { "ProductId" });
            DropIndex("dbo.SalesOrders", new[] { "CustomerId" });
            AddColumn("dbo.PurchaseOrders", "ProductName", c => c.String());
            AddColumn("dbo.PurchaseOrders", "SupplierName", c => c.String());
            AddColumn("dbo.SalesOrders", "ProductName", c => c.String());
            AddColumn("dbo.SalesOrders", "CustomerName", c => c.String());
            DropColumn("dbo.PurchaseOrders", "ProductId");
            DropColumn("dbo.PurchaseOrders", "SupplierId");
            DropColumn("dbo.SalesOrders", "ProductId");
            DropColumn("dbo.SalesOrders", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesOrders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.SalesOrders", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseOrders", "SupplierId", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseOrders", "ProductId", c => c.Int(nullable: false));
            DropColumn("dbo.SalesOrders", "CustomerName");
            DropColumn("dbo.SalesOrders", "ProductName");
            DropColumn("dbo.PurchaseOrders", "SupplierName");
            DropColumn("dbo.PurchaseOrders", "ProductName");
            CreateIndex("dbo.SalesOrders", "CustomerId");
            CreateIndex("dbo.SalesOrders", "ProductId");
            CreateIndex("dbo.PurchaseOrders", "SupplierId");
            CreateIndex("dbo.PurchaseOrders", "ProductId");
            AddForeignKey("dbo.SalesOrders", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SalesOrders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseOrders", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseOrders", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
