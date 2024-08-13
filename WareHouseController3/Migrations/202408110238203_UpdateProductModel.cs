namespace WareHouseController3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductCategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductCategoryId");
        }
    }
}
