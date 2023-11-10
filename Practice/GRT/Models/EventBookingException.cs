using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.Models
{
    public class EventBookingException:Exception
    {
        public EventBookingException(string message):base(message)
        {
            
        }
    }
}