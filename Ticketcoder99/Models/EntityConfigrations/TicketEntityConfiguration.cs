using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketcoder99.Models.Enitites;

namespace Ticketcoder99.Models.EntityConfigrations
{
    public class TicketEntityConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
           builder .HasKey(t => t.Id);
            builder.Property (t => t.Id).UseIdentityColumn ();  



        }
    }
}
