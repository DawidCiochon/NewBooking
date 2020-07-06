using System.Collections.Generic;

namespace BookingTickets.Models
{
    public class Movies
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public int Duration {get; set;}
        public ICollection<Seance> Seances {get; set;}
    }
}