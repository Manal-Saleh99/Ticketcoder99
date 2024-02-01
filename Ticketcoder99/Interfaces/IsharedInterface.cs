using Ticketcoder99.DTOs.Authantication;
using Ticketcoder99.DTOs.Events;

namespace Ticketcoder99.Interfaces
{
    public interface IsharedInterface
    {    // filltering Event
        Task<List<EventInfoDto>> GetEvents(string? title, DateTime? time, int? type);
        //get event details by id 
        Task<EventDetailsDTO> GetEventDetails(int Id);
        // regierstation 

        Task CreateNewAccount(RegerstrationDTO dto);
        // login 
        Task Login(LoginDTO dto);



        //resetpassword

        Task ResetPassword(ResetPasswordDTO dto);


    }
}
