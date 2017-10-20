namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Routes", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Stops", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stops", "DateCreated");
            DropColumn("dbo.Users", "DateCreated");
            DropColumn("dbo.Routes", "DateCreated");
        }
    }
}
