using static Ticketcoder99.Helper.Enums.Enums;

namespace Ticketcoder99.DTOs.Tickets
{
    public class TicketDto
    {

        public int  Id { get; set; }

        public int EventId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string TicketNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int Quantity { get; set; }
        public int AvaliableQuantity { get; set; }
        public float Price { get; set; }


        public string  TicketType { get; set; }




    }
}
