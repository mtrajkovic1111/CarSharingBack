namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTotalPriceToCarRentalTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarRentals", "TotalPricePerDay", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarRentals", "TotalPricePerDay");
        }
    }
}
