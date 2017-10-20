namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class password : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Routes", "DateCreated");
            DropColumn("dbo.Users", "DateCreated");
            DropColumn("dbo.Stops", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stops", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routes", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "Password");
        }
    }
}
