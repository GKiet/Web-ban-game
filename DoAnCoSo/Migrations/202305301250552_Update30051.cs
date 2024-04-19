namespace DoAnCoSo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update30051 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "PriceSale");
        }
    }
}
