namespace mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3e58891e-29c4-4673-a67c-6f34e39f1a90', N'Admin@aol.com', 0, N'AJHhcNQdQlOuCqrH6LEwBMfKkx6J5ViAP+GnT2+krJx2kR6x/AZY2Cx/hdJWR6Xi9g==', N'683fe284-ed92-4f53-98fb-9a7cfb6f331d', NULL, 0, 0, NULL, 1, 0, N'Admin@aol.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b046bb87-b8bd-46bb-b254-2c01087ee9b0', N'Guest@aol.com', 0, N'AHryfX7CFJciPJi91MKwLD+JiUXNgXgLelftFiWGb/5FNVLWtaekbAeOvuvKzhBzZg==', N'cc02c64d-4915-4272-a794-7b62939eab96', NULL, 0, 0, NULL, 1, 0, N'Guest@aol.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f80adcd3-6a71-4ce6-8890-8b54699108d3', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3e58891e-29c4-4673-a67c-6f34e39f1a90', N'f80adcd3-6a71-4ce6-8890-8b54699108d3')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b046bb87-b8bd-46bb-b254-2c01087ee9b0', N'f80adcd3-6a71-4ce6-8890-8b54699108d3')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
