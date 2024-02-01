using Ticketcoder99.DTOs.Tickets;

namespace Ticketcoder99.DTOs.Events
{
    public class EventDetailsDTO
    {
        // get basic info about event 
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Type { get; set; }
        public float StartingPrice { get; set; }
        public DateTime EventDate { get; set; }

        public int AvailableTicketCount { get; set; }
        // get detaled info about event 
        public string Address { get; set; }

        public int TakingSeates { get; set; }

        // get tickets 
        public List<TicketDto> Tickets { get; set; }

    }
}
