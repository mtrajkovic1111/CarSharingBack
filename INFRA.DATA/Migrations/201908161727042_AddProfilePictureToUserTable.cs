namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfilePictureToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ProfilePicture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ProfilePicture");
        }
    }
}
