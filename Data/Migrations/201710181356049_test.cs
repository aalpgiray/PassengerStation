namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Routes", "IsDeleted");
            DropColumn("dbo.Users", "IsDeleted");
            DropColumn("dbo.Stops", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stops", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Routes", "IsDeleted", c => c.Boolean(nullable: false));
        }
    }
}
