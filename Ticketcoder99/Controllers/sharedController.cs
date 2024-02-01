using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketcoder99.DTOs.Authantication;
using Ticketcoder99.DTOs.Events;
using Ticketcoder99.Interfaces;

namespace Ticketcoder99.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sharedController : ControllerBase, IsharedInterface
    {
        #region Get Information 
        [HttpGet]
        [Route("[action]")]
        public Task<EventDetailsDTO> GetEventDetails(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("[action]")]
        public Task<List<EventInfoDto>> GetEvents(string? title, DateTime? time, int? type)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region Authatication

        [HttpPost]
        [Route("[action]")]
        public Task CreateNewAccount(RegerstrationDTO dto)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("[action]")]

        public Task Login(LoginDTO dto)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        [Route("[action]")]
        public Task ResetPassword(ResetPasswordDTO dto)
        {
            throw new NotImplementedException();
        }


        #endregion 
    }
}
