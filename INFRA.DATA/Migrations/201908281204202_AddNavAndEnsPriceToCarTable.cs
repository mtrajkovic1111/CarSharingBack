namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNavAndEnsPriceToCarTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "NavigationPrice", c => c.Byte());
            AddColumn("dbo.Cars", "EnsurancePrice", c => c.Byte());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "EnsurancePrice");
            DropColumn("dbo.Cars", "NavigationPrice");
        }
    }
}
