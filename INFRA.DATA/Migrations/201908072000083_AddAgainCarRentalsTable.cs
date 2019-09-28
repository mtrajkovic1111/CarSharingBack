namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgainCarRentalsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarRentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromDate = c.DateTime(nullable: false),
                        TillDate = c.DateTime(nullable: false),
                        CarId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.CarId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarRentals", "UserId", "dbo.Users");
            DropForeignKey("dbo.CarRentals", "CarId", "dbo.Cars");
            DropIndex("dbo.CarRentals", new[] { "UserId" });
            DropIndex("dbo.CarRentals", new[] { "CarId" });
            DropTable("dbo.CarRentals");
        }
    }
}
