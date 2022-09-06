using Microsoft.EntityFrameworkCore;
using pdemo.Models;

namespace pdemo
{
    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions<TicketsContext> options) : base(options) { }
        public DbSet<FlyOnTickets> WebLoggingTicket { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlyOnTickets>().ToTable("FlyOnTickets");
            //modelBuilder.Entity<FlyOn>().ToView(nameof(FlyOn)).HasKey(t => t.MemberID);
        }
        public DbSet<pdemo.Models.FlyOnTickets> FlyOnTickets { get; set; }
    }
}
