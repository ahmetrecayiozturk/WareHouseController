namespace WareHouseController3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrders", "Address", c => c.String());
            AddColumn("dbo.PurchaseOrders", "ContactInfo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseOrders", "ContactInfo");
            DropColumn("dbo.PurchaseOrders", "Address");
        }
    }
}
