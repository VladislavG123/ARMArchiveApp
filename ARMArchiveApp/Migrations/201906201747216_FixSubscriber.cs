namespace ARMArchiveApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixSubscriber : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Subscribers", "GettingDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subscribers", "GettingDate", c => c.DateTime(nullable: false));
        }
    }
}
