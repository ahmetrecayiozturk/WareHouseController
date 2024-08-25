namespace WareHouseController3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalesOrders", "CustomerContact", c => c.String());
            AddColumn("dbo.SalesOrders", "CustomerAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SalesOrders", "CustomerAddress");
            DropColumn("dbo.SalesOrders", "CustomerContact");
        }
    }
}
