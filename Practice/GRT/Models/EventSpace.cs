using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GRT.Models
{
    public class EventSpace
    {
        [Key]
        public int SpaceId{get;set;}
        public int Capacity{get;set;}
        public string Availability{get;set;}
        public ICollection<Booking>? Bookings{get;set;}
    }
}