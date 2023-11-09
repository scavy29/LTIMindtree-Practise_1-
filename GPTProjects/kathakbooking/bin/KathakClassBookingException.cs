using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kathakbooking.bin
{
public class KathakClassBookingException : Exception
{
    public KathakClassBookingException() { }

    public KathakClassBookingException(string message) : base(message) { }

    public KathakClassBookingException(string message, Exception innerException)
        : base(message, innerException) { }
}
}