namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBrandsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Brands (Name) VALUES ('Alfa Romeo')");
            Sql("INSERT INTO Brands (Name) VALUES ('Audi')");
            Sql("INSERT INTO Brands (Name) VALUES ('BMW')");
            Sql("INSERT INTO Brands (Name) VALUES ('Citroen')");
            Sql("INSERT INTO Brands (Name) VALUES ('Dacia')");
            Sql("INSERT INTO Brands (Name) VALUES ('Fiat')");
            Sql("INSERT INTO Brands (Name) VALUES ('Ford')");
            Sql("INSERT INTO Brands (Name) VALUES ('Honda')");
            Sql("INSERT INTO Brands (Name) VALUES ('Hyundai')");
            Sql("INSERT INTO Brands (Name) VALUES ('Kia')");
            Sql("INSERT INTO Brands (Name) VALUES ('Mazda')");
            Sql("INSERT INTO Brands (Name) VALUES ('Mercedes Benz')");
            Sql("INSERT INTO Brands (Name) VALUES ('Nissan')");
            Sql("INSERT INTO Brands (Name) VALUES ('Opel')");
            Sql("INSERT INTO Brands (Name) VALUES ('Peugeot')");
            Sql("INSERT INTO Brands (Name) VALUES ('Reanult')");
            Sql("INSERT INTO Brands (Name) VALUES ('Skoda')");
            Sql("INSERT INTO Brands (Name) VALUES ('Toyota')");
            Sql("INSERT INTO Brands (Name) VALUES ('Wolkswagen')");
            Sql("INSERT INTO Brands (Name) VALUES ('Volvo')");
        }
        
        public override void Down()
        {
        }
    }
}
