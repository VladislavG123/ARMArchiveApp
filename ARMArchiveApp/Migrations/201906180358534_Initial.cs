namespace ARMArchiveApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Archives",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Rack = c.Int(nullable: false),
                        Shelf = c.Int(nullable: false),
                        Cell = c.Int(nullable: false),
                        Fullness = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GettingDate = c.DateTime(nullable: false),
                        Subscriber_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subscribers", t => t.Subscriber_Id)
                .Index(t => t.Subscriber_Id);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FullName = c.String(),
                        Department = c.String(),
                        Phone = c.String(),
                        GettingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.Int(nullable: false),
                        Name = c.String(),
                        Cell = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        GettingDate = c.DateTime(nullable: false),
                        ReceiptDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "Subscriber_Id", "dbo.Subscribers");
            DropIndex("dbo.Deliveries", new[] { "Subscriber_Id" });
            DropTable("dbo.Documents");
            DropTable("dbo.Subscribers");
            DropTable("dbo.Deliveries");
            DropTable("dbo.Archives");
        }
    }
}
