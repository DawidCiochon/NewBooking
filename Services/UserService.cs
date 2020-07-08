using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using BookingTickets.Helpers;
using BookingTickets.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BookingTickets.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly BookingTicketsContext _context;
        public UserService(IOptions<AppSettings> appSettings, BookingTicketsContext context){
            this._appSettings = appSettings.Value;
            this._context = context;
        }

        

        private List<User> _users = new List<User>
        { 
            new User { Id = 1, FirstName = "Test", LastName = "User", Email = "test", Password = "test" } 
        };

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            /*var user = new User(){
                Id = 1,
                FirstName = "Testowy",
                LastName = "Test",
                Email = "ddd@ddd.pl",
                Password = "qwerty1234"
            };

            _context.Users.Add(user);
            _context.SaveChanges();*/
            var user_1 = _context.Users.SingleOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            if(user_1 == null) return null;

            var token = generateJwtToken(user_1);

            return new AuthenticateResponse(user_1, token);
        }

        private string generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)    
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


    }
}