using Microsoft.EntityFrameworkCore;
using Ticketcoder99.Models.Enitites;
using Ticketcoder99.Models.EntityConfigrations;

namespace Ticketcoder99.Context
{
    public class TicketCoderDbContext : DbContext
    {
        public TicketCoderDbContext(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserTickets>().Property(x => x.TicketSerailNumber).IsRequired();
            modelBuilder .Entity <UserTickets >().HasKey(x => x.Id );
            modelBuilder.Entity<UserTickets>().Property(x => x.Id ).UseIdentityColumn ();

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder .ApplyConfiguration (new TicketEntityConfiguration ());
            modelBuilder .ApplyConfiguration(new EventEntityConfiguration ());  
        }

        public virtual DbSet <Event> Events { get; set; }

        public virtual DbSet<Ticket > Tickets { get; set; }


        public virtual DbSet<User > Users { get; set; }


        public virtual DbSet<UserTickets > UserTickets { get; set; }

    }
}
