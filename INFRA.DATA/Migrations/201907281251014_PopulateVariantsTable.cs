namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVariantsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Variants (BodyType) VALUES ('Hatchback')");
            Sql("INSERT INTO Variants (BodyType) VALUES ('Estate')"); //karavan
            Sql("INSERT INTO Variants (BodyType) VALUES ('SUV')");
            Sql("INSERT INTO Variants (BodyType) VALUES ('Coupe')");
            Sql("INSERT INTO Variants (BodyType) VALUES ('Convertible')"); //kabriolet
            Sql("INSERT INTO Variants (BodyType) VALUES ('Saloon')");
        }
        
        public override void Down()
        {
        }
    }
}
