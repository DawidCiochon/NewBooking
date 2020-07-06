using System;
using System.ComponentModel.DataAnnotations;

namespace BookingTickets.Models
{
    public class Seat
    {
        [Key]
        public int Number {get; set;}
        public bool Occupied {get; set;} 
        public int ReservationId {get; set;}
    }
}