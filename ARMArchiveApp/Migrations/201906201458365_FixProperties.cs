namespace ARMArchiveApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Deliveries", "Document_Id", c => c.Guid());
            CreateIndex("dbo.Deliveries", "Document_Id");
            AddForeignKey("dbo.Deliveries", "Document_Id", "dbo.Documents", "Id");
            DropColumn("dbo.Documents", "GettingDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Documents", "GettingDate", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Deliveries", "Document_Id", "dbo.Documents");
            DropIndex("dbo.Deliveries", new[] { "Document_Id" });
            DropColumn("dbo.Deliveries", "Document_Id");
        }
    }
}
