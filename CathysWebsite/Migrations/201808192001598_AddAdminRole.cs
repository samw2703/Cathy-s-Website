namespace CathysWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminRole : DbMigration
    {
        public override void Up()
        {
            var sql = @"
INSERT INTO [dbo].[AspNetUsers] 
    ([Id], 
    [Email], 
    [EmailConfirmed], 
    [PasswordHash], 
    [SecurityStamp], 
    [PhoneNumber], 
    [PhoneNumberConfirmed], 
    [TwoFactorEnabled], 
    [LockoutEndDateUtc], 
    [LockoutEnabled], 
    [AccessFailedCount], 
    [UserName]) 
VALUES (
    N'30050d1f-0fb7-4d6c-a72c-132974c92c56', 
    N'samw2703@gmail.com', 
    0, 
    N'ANqt76/tzs30cVmDMj+MSuYA6DpQwrczWeqMs1lCD0DzgblOedXUbsbYuLkNfmuwRw==', 
    N'862bedc4-97f7-42fc-98d9-5f471482a4b4', 
    NULL, 
    0, 
    0, 
    NULL, 
    1, 
    0, 
    N'samw2703@gmail.com'
)

INSERT INTO [dbo].[AspNetRoles] (
    [Id], 
    [Name]
) 
VALUES (
    N'c9caacb5-0434-4bf9-b717-93e364fe4503', 
    N'Admin'
)

INSERT INTO [dbo].[AspNetUserRoles] (
    [UserId], 
    [RoleId]
) 
VALUES (
    N'30050d1f-0fb7-4d6c-a72c-132974c92c56', 
    N'c9caacb5-0434-4bf9-b717-93e364fe4503'
)
";

            Sql(sql);
        }
        
        public override void Down()
        {
        }
    }
}
