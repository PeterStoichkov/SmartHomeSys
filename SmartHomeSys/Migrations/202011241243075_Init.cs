namespace SmartHomeSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clusters",
                c => new
                    {
                        ClusterId = c.Int(nullable: false, identity: true),
                        User_Username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClusterId)
                .ForeignKey("dbo.Users", t => t.User_Username)
                .Index(t => t.User_Username);
            
            CreateTable(
                "dbo.Lamps",
                c => new
                    {
                        LampId = c.Int(nullable: false, identity: true),
                        Colour = c.String(),
                    })
                .PrimaryKey(t => t.LampId);
            
            CreateTable(
                "dbo.Locks",
                c => new
                    {
                        LockId = c.Int(nullable: false, identity: true),
                        PinCode = c.String(),
                    })
                .PrimaryKey(t => t.LockId);
            
            CreateTable(
                "dbo.Televisions",
                c => new
                    {
                        TelevisionId = c.Int(nullable: false, identity: true),
                        Channel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TelevisionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clusters", "User_Username", "dbo.Users");
            DropIndex("dbo.Clusters", new[] { "User_Username" });
            DropTable("dbo.Users");
            DropTable("dbo.Televisions");
            DropTable("dbo.Locks");
            DropTable("dbo.Lamps");
            DropTable("dbo.Clusters");
        }
    }
}
