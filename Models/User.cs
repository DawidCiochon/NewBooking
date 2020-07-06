using System.Collections.Generic;

namespace BookingTickets.Models
{
    public enum UserType{
        client = 0,
        admin = 1
    }
    public class User
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public UserType userType {get; set;}
        public ICollection<Reservation> Reservations {get; set;}
    }
}