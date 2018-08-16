namespace CathysWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddByteImageToReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Image", c => c.Binary());
            DropColumn("dbo.Reviews", "Imagepath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Imagepath", c => c.String());
            DropColumn("dbo.Reviews", "Image");
        }
    }
}
