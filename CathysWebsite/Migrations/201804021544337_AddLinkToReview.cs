namespace CathysWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinkToReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Link");
        }
    }
}
