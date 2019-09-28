namespace INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumberToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ContactPhone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ContactPhone");
        }
    }
}
