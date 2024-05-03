using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.DatabaseCommunication
{
    public class SuperBetDb: DbContext
    {
        public DbSet<Addict> Addicts { get; set; }
        public DbSet<Odds> Odds { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\JOZIK\\MUNI\\pv178\\SuperBet\\SuperBet\\Data\\database");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Odds>()
       .HasKey(o => o.OddID);

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
