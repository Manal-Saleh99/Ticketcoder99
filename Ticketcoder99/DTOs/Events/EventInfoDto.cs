namespace Ticketcoder99.DTOs.Events
{
    public class EventInfoDto
    {

        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Type { get; set; }
        public float StartingPrice { get; set; }
        public DateTime EventDate { get; set; }

        public int AvailableTicketCount { get; set; }



    }
}
