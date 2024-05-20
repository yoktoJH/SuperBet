using Microsoft.EntityFrameworkCore;

namespace SuperBet.DatabaseCommunication
{
    public class SuperBetDb : DbContext
    {
        public DbSet<Addict> Addicts { get; set; }
        public DbSet<Odds> Odds { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        
        public readonly string _path;

        public SuperBetDb(string path):base()
        {
            _path = path;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_path);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Odds>()
       .HasKey(o => o.OddID);
            modelBuilder.Entity<Ticket>().HasKey(t => t.TicketId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Odds)
                .WithMany(o => o.Tickets)
                .HasForeignKey(t => t.OddID);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Addict)
                .WithMany(a => a.Tickets)
                .HasForeignKey(t => t.Id);
        }
    }
}
