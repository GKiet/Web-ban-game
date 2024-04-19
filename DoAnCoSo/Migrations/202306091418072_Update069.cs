namespace DoAnCoSo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update069 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "IsHome", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "IsHome");
        }
    }
}
