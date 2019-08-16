namespace EuroFinService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskToDo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskToDoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskToDoes");
        }
    }
}
