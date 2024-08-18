namespace WareHouseController3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrders", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseOrders", "SupplierId", c => c.Int(nullable: false));
            AddColumn("dbo.SalesOrders", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.SalesOrders", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.PurchaseOrders", "ProductId");
            CreateIndex("dbo.PurchaseOrders", "SupplierId");
            CreateIndex("dbo.SalesOrders", "ProductId");
            CreateIndex("dbo.SalesOrders", "CustomerId");
            AddForeignKey("dbo.PurchaseOrders", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseOrders", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SalesOrders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SalesOrders", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            DropColumn("dbo.PurchaseOrders", "ProductName");
            DropColumn("dbo.PurchaseOrders", "SupplierName");
            DropColumn("dbo.SalesOrders", "ProductName");
            DropColumn("dbo.SalesOrders", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesOrders", "CustomerName", c => c.String());
            AddColumn("dbo.SalesOrders", "ProductName", c => c.String());
            AddColumn("dbo.PurchaseOrders", "SupplierName", c => c.String());
            AddColumn("dbo.PurchaseOrders", "ProductName", c => c.String());
            DropForeignKey("dbo.SalesOrders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SalesOrders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.PurchaseOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.PurchaseOrders", "ProductId", "dbo.Products");
            DropIndex("dbo.SalesOrders", new[] { "CustomerId" });
            DropIndex("dbo.SalesOrders", new[] { "ProductId" });
            DropIndex("dbo.PurchaseOrders", new[] { "SupplierId" });
            DropIndex("dbo.PurchaseOrders", new[] { "ProductId" });
            DropColumn("dbo.SalesOrders", "CustomerId");
            DropColumn("dbo.SalesOrders", "ProductId");
            DropColumn("dbo.PurchaseOrders", "SupplierId");
            DropColumn("dbo.PurchaseOrders", "ProductId");
        }
    }
}
