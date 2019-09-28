namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTransmissionTable : DbMigration
    {
        public override void Up()
        {
            {
                Sql("INSERT INTO Transmissions (Type) VALUES ('manual')");
                Sql("INSERT INTO Transmissions (Type) VALUES ('automatic')");

            }
        }
        
        public override void Down()
        {
        }
    }
}
