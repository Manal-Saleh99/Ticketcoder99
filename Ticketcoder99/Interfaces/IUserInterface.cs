using Ticketcoder99.DTOs.Authantication;
using Ticketcoder99.DTOs.Events;
using Ticketcoder99.DTOs.Tickets;

namespace Ticketcoder99.Interfaces
{
    public interface IUserInterface
    {

    

        // buyticket

        Task BuyTickets(BuyTicketDTO dto);

        //gettickethistory by user id 

        Task <List<UserTicketDTO >> GetTicketHistoryByUserId(int Id );








    }
}
