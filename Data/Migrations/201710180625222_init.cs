namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestDate = c.DateTime(nullable: false),
                        ValidUntil = c.DateTime(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Requester_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Requester_Id, cascadeDelete: true)
                .Index(t => t.Requester_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        UserRole = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StopType = c.Int(nullable: false),
                        Geography = c.Geography(),
                        IsDeleted = c.Boolean(nullable: false),
                        Route_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.Route_Id, cascadeDelete: true)
                .Index(t => t.Route_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stops", "Route_Id", "dbo.Routes");
            DropForeignKey("dbo.Routes", "Requester_Id", "dbo.Users");
            DropIndex("dbo.Stops", new[] { "Route_Id" });
            DropIndex("dbo.Routes", new[] { "Requester_Id" });
            DropTable("dbo.Stops");
            DropTable("dbo.Users");
            DropTable("dbo.Routes");
        }
    }
}
