namespace DoAnCoSo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update30052 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Product", "Price", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.tb_Product", "PriceSale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tb_Product", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
