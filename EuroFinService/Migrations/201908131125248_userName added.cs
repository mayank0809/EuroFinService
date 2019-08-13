namespace EuroFinService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userNameadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaskToDoes", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaskToDoes", "UserName");
        }
    }
}
