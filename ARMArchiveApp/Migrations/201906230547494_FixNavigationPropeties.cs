namespace ARMArchiveApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixNavigationPropeties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "Theme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "Theme");
        }
    }
}
