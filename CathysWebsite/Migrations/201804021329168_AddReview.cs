namespace CathysWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        DateWritten = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
        }
    }
}
