using BookingTickets.Models;

namespace BookingTickets.Services
{
    public interface IUserService
    {
         AuthenticateResponse Authenticate(AuthenticateRequest model);
    }
}