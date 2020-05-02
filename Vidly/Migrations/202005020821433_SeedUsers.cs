namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'37bbfd91-db7b-4218-a983-a8224429469f', N'abc@gmail.com', 0, N'AMrBwUbna7I9xgmdKaNOmM1L0ecIF3xWOkKI1W+I9Z2FOLAtiRL/jumZ4h9MRiPkxA==', N'b3d72776-af32-44fd-bb18-426eac79c556', NULL, 0, 0, NULL, 1, 0, N'abc@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af5cfc3b-5d23-4230-aeb9-7c09d7ef5f0e', N'admin@gmail.com', 0, N'ACI+iCKI68l3yF+2SsGvu2ccod880t1WY9nL7EvyIrteb0Qld/T9ezoU+U5AKFYmXg==', N'1581d8aa-499b-4d0a-9704-bcddc683abf3', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2dd5959f-66e5-4cec-8d2d-a37ee86cb6aa', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'af5cfc3b-5d23-4230-aeb9-7c09d7ef5f0e', N'2dd5959f-66e5-4cec-8d2d-a37ee86cb6aa')
");
        }
        
        public override void Down()
        {
        }
    }
}
