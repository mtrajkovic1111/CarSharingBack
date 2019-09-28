namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCarRentalsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CarRentals", "Id", "dbo.Cars");
            DropForeignKey("dbo.CarRentals", "UserId", "dbo.Users");
            DropIndex("dbo.CarRentals", new[] { "Id" });
            DropIndex("dbo.CarRentals", new[] { "UserId" });
            DropTable("dbo.CarRentals");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CarRentals",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        TillDate = c.DateTime(nullable: false),
                        CarId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.CarRentals", "UserId");
            CreateIndex("dbo.CarRentals", "Id");
            AddForeignKey("dbo.CarRentals", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CarRentals", "Id", "dbo.Cars", "Id");
        }
    }
}
