using System;
namespace BookingTickets.Models
{
    public class Seat
    {
        public int Number {get; set;}
        public bool Occupied {get; set;} 
        public int ReservationId {get; set;}
    }
}