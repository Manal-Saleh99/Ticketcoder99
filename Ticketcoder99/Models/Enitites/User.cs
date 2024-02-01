﻿namespace Ticketcoder99.Models.Enitites
{
    public class User
    {   

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual List <UserTickets > UserTickets { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
