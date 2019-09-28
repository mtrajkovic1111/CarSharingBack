namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteACfromCarRentalTableAgain : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CarRentals", "RentedWithAirCondition");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CarRentals", "RentedWithAirCondition", c => c.Boolean(nullable: false));
        }
    }
}
