namespace CathysWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagePathToReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Imagepath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Imagepath");
        }
    }
}
