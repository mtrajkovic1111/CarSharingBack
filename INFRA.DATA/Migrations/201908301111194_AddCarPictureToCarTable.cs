namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarPictureToCarTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarPicture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "CarPicture");
        }
    }
}
