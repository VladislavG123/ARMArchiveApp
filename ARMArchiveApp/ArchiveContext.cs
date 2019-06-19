namespace ARMArchiveApp
{
    using ARMArchiveApp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ArchiveContext : DbContext
    {
        
        public ArchiveContext()
            : base("name=ArchiveContext")
        {
        }
        
        public DbSet<Archive> Archives { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
    }
}