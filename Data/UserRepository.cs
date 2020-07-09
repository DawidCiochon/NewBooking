using System;
using System.Security.Claims;
using System.Text;
using System.Linq;
using BookingTickets.Models;
using BookingTickets.Helpers;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace BookingTickets.Data
{
    public class UserRepository : Repository<User, BookingTicketsContext>
    {
         
        public UserRepository(BookingTicketsContext context) : base(context){
            
        }   

        
    }
}