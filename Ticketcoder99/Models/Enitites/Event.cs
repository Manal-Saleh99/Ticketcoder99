using System.Diagnostics;
using static Ticketcoder99.Helper.Enums.Enums;

namespace Ticketcoder99.Models.Enitites
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime EventTime { get; set; }
      
        public string Address { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public EventType EventType { get; set; }



        public virtual List<Ticket > Tickets  { get; set; }
    }
}
