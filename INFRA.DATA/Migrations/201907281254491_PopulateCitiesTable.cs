namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCitiesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cities (Name) VALUES ('Belgrade')");
            Sql("INSERT INTO Cities (Name) VALUES ('Novi Sad')");
            Sql("INSERT INTO Cities (Name) VALUES ('NIs')");
            Sql("INSERT INTO Cities (Name) VALUES ('Pristina')");
            Sql("INSERT INTO Cities (Name) VALUES ('Kragujevac')");
            Sql("INSERT INTO Cities (Name) VALUES ('Leskovac')");
            Sql("INSERT INTO Cities (Name) VALUES ('Subotica')");
            Sql("INSERT INTO Cities (Name) VALUES ('Zrenjanin')");
            Sql("INSERT INTO Cities (Name) VALUES ('Pancevo')");
            Sql("INSERT INTO Cities (Name) VALUES ('Cacak')");
            Sql("INSERT INTO Cities (Name) VALUES ('Novi Pazar')");
            Sql("INSERT INTO Cities (Name) VALUES ('Kraljevo')");
            Sql("INSERT INTO Cities (Name) VALUES ('Smederevo')");
            Sql("INSERT INTO Cities (Name) VALUES ('Valjevo')");
            Sql("INSERT INTO Cities (Name) VALUES ('Krusevac')");
            Sql("INSERT INTO Cities (Name) VALUES ('Vranje')");
            Sql("INSERT INTO Cities (Name) VALUES ('Sabac')");
            Sql("INSERT INTO Cities (Name) VALUES ('Uzice')");
            Sql("INSERT INTO Cities (Name) VALUES ('Sombor')");
            Sql("INSERT INTO Cities (Name) VALUES ('Pozarevac')");
            Sql("INSERT INTO Cities (Name) VALUES ('Zajecar')");
            Sql("INSERT INTO Cities (Name) VALUES ('Sremska Mitrovica')");

        }

        public override void Down()
        {
        }
    }
}
