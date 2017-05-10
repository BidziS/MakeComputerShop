namespace MakeComputerShop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9d71892c-eda1-4372-8c47-768e4a7c33dc', N'admin@cebule.net', 0, N'ALjEjtJWQ1HngJf22n4kB0NX0f/uxVlmckEGGA6rcYVb8/uW7IKOI4MCOWMDq7U0Mw==', N'0b6c90d3-098b-478e-a058-95b6026a530d', NULL, 0, 0, NULL, 1, 0, N'admin@cebule.net')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'edca4bfb-ce57-4d71-b34a-dbd6b7ab440b', N'guest@vidly.com', 0, N'AKyOtgvAnnwJozYb8VaryKkuJB3dMkgMoWaYHh1XYaB6aajpNgcUMom2jv6IdSNVQA==', N'ff7b0ada-aaa7-42a1-ae54-bef9bc772b96', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2bb1f6bc-d8bb-4f5d-afc0-5dc7337d2b58', N'Admin')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9d71892c-eda1-4372-8c47-768e4a7c33dc', N'2bb1f6bc-d8bb-4f5d-afc0-5dc7337d2b58')


                ");
        }
        
        public override void Down()
        {
        }
    }
}
