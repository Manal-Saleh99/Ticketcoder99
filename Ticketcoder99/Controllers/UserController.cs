using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketcoder99.DTOs.Tickets;
using Ticketcoder99.Interfaces;

namespace Ticketcoder99.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase, IUserInterface
    {
        [HttpGet]
        [Route("[action]")]
        public Task<List<UserTicketDTO>> GetTicketHistoryByUserId(int Id)
        {
            throw new NotImplementedException();
        }



        [HttpPost]
        [Route ("Buy")]

        public Task BuyTickets(BuyTicketDTO dto)
        {
            throw new NotImplementedException();
        }
      
    }
}
