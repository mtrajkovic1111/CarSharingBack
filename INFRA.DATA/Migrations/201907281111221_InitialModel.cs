namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(nullable: false),
                        Number = c.String(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LicencePlate = c.String(),
                        EngineSize = c.Int(nullable: false),
                        Doors = c.Byte(nullable: false),
                        Year = c.Int(nullable: false),
                        PricePerDay = c.Byte(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                        HasNavigation = c.Boolean(nullable: false),
                        HasEnsurance = c.Boolean(nullable: false),
                        HasAirCondition = c.Boolean(nullable: false),
                        TransmissionId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Transmissions", t => t.TransmissionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.TransmissionId)
                .Index(t => t.AddressId)
                .Index(t => t.VehicleId)
                .Index(t => t.UserId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Rate = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fuel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelId = c.Int(nullable: false),
                        VariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.Variants", t => t.VariantId, cascadeDelete: true)
                .Index(t => t.ModelId)
                .Index(t => t.VariantId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelType = c.String(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Variants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BodyType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuelTypeCars",
                c => new
                    {
                        Car_Id = c.Int(nullable: false),
                        FuelType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Car_Id, t.FuelType_Id })
                .ForeignKey("dbo.Cars", t => t.Car_Id, cascadeDelete: true)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_Id, cascadeDelete: true)
                .Index(t => t.Car_Id)
                .Index(t => t.FuelType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cars", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "VariantId", "dbo.Variants");
            DropForeignKey("dbo.Vehicles", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Models", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Cars", "UserId", "dbo.Users");
            DropForeignKey("dbo.Cars", "TransmissionId", "dbo.Transmissions");
            DropForeignKey("dbo.FuelTypeCars", "FuelType_Id", "dbo.FuelTypes");
            DropForeignKey("dbo.FuelTypeCars", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.CarRentals", "UserId", "dbo.Users");
            DropForeignKey("dbo.CarRentals", "Id", "dbo.Cars");
            DropForeignKey("dbo.Cars", "AddressId", "dbo.Addresses");
            DropIndex("dbo.FuelTypeCars", new[] { "FuelType_Id" });
            DropIndex("dbo.FuelTypeCars", new[] { "Car_Id" });
            DropIndex("dbo.Models", new[] { "BrandId" });
            DropIndex("dbo.Vehicles", new[] { "VariantId" });
            DropIndex("dbo.Vehicles", new[] { "ModelId" });
            DropIndex("dbo.CarRentals", new[] { "UserId" });
            DropIndex("dbo.CarRentals", new[] { "Id" });
            DropIndex("dbo.Cars", new[] { "UserId" });
            DropIndex("dbo.Cars", new[] { "VehicleId" });
            DropIndex("dbo.Cars", new[] { "AddressId" });
            DropIndex("dbo.Cars", new[] { "TransmissionId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropTable("dbo.FuelTypeCars");
            DropTable("dbo.Cities");
            DropTable("dbo.Variants");
            DropTable("dbo.Brands");
            DropTable("dbo.Models");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Transmissions");
            DropTable("dbo.FuelTypes");
            DropTable("dbo.Users");
            DropTable("dbo.CarRentals");
            DropTable("dbo.Cars");
            DropTable("dbo.Addresses");
        }
    }
}
