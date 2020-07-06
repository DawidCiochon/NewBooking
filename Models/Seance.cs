using System;
using System.Collections.Generic;

namespace BookingTickets.Models
{
    public class Seance //event
    {
        public int Id {get; set;}
        public DateTime StartDate {get; set;}
        public int MovieId {get; set;}
        public int reservationId {get; set;}
        public int RoomId {get; set;}
    }
}