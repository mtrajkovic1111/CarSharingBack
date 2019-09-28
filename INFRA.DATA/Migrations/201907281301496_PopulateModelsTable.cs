namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateModelsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('147', 1)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('A4', 2)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('A5', 2)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('A6', 2)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Q2', 2)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Q3', 2)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('TT', 2)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('114', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('116', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('216', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('X1', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('X3', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('320', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('325', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('525', 3)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('C5', 4)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Sandero', 5)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Stillo', 6)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Chroma', 6)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Focus', 7)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Escort', 7)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Mondeo', 7)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Accord', 8)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Tucson', 9)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('i30', 9)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Sorento', 10)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Sportage', 10)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('3', 11)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('5', 11)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('A 140', 12)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('C 200', 12)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('E 200', 12)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Patrol', 13)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Qashqai', 13)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Navara', 13)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Astra', 14)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Corsa', 14)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Insignia', 14)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Antara', 14)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('307', 15)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('308', 15)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('3008', 15)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Megane', 16)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Laguna', 16)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Fabia', 17)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Octavia', 17)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('RAW4', 18)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Auris', 18)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Golf4', 19)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Golf5', 19)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('Passat B6', 19)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('C30', 20)");
            Sql("INSERT INTO Models (ModelType, BrandId) VALUES ('S60', 20)");

        }

        public override void Down()
        {
        }
    }
}
