using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.Models
{
    public class Booking
    {
        public int BookingId{get;set;}
        public int SpaceId{get;set;}
        public int OrganizerId{get;set;}
        public DateTime EventDate{get;set;}
        public TimeOnly TimeSlot{get;set;}
        public EventSpace? EventSpace{get;set;}
    }
}