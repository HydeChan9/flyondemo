using Microsoft.EntityFrameworkCore;
using pdemo.Models;

namespace pdemo
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<FlyOn> WebLogging { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlyOn>().ToTable("FlyOnMember");
            //modelBuilder.Entity<FlyOn>().ToView(nameof(FlyOn)).HasKey(t => t.MemberID);
        }
        public DbSet<FlyOn> FlyOn{ get; set; }
    }
}