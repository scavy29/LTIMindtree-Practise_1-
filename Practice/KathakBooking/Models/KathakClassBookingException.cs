using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KathakBooking.Models
{
    public class KathakClassBookingException:Exception
    {
        public KathakClassBookingException(string message):base(message){}
    }
}