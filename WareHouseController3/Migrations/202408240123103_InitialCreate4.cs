namespace WareHouseController3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PurchaseOrders", "Address");
            DropColumn("dbo.PurchaseOrders", "ContactNumber");
            DropColumn("dbo.SalesOrders", "Address");
            DropColumn("dbo.SalesOrders", "ContactNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesOrders", "ContactNumber", c => c.Int(nullable: false));
            AddColumn("dbo.SalesOrders", "Address", c => c.String());
            AddColumn("dbo.PurchaseOrders", "ContactNumber", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseOrders", "Address", c => c.String());
        }
    }
}
