namespace Ticketcoder99.Models.Enitites
{
    public class UserTickets
    { 
        public int Id { get; set; } 
        public DateTime PurshesDate { get; set; }
        public string TicketSerailNumber { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual User User { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
