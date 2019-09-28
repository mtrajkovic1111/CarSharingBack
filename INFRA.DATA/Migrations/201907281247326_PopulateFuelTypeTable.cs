namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFuelTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO FuelTypes (Fuel) VALUES ('gasoline')");
            Sql("INSERT INTO FuelTypes (Fuel) VALUES ('diesel')");
            Sql("INSERT INTO FuelTypes (Fuel) VALUES ('gas')");
        }
        
        public override void Down()
        {
        }
    }
}
