namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExtrasToCarRentalTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarRentals", "RentedWithNavigation", c => c.Boolean(nullable: false));
            AddColumn("dbo.CarRentals", "RentedWithEnsurance", c => c.Boolean(nullable: false));
            AddColumn("dbo.CarRentals", "RentedWithAirCondition", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarRentals", "RentedWithAirCondition");
            DropColumn("dbo.CarRentals", "RentedWithEnsurance");
            DropColumn("dbo.CarRentals", "RentedWithNavigation");
        }
    }
}
