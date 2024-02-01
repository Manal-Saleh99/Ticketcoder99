using static Ticketcoder99.Helper.Enums.Enums;

namespace Ticketcoder99.Models.Enitites
{
    public class Ticket
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TicketNumber { get; set; }
        public DateTime GeneratedTime { get; set; }
         public DateTime ExpirationDate { get; set; }

        public int Quantity { get; set; }

        public float  Price { get; set; }

     
      public TicketType TicketType { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Event Event { get; set; }

        public virtual List<UserTickets> UserTickets { get; set; }



    }
    }
    
