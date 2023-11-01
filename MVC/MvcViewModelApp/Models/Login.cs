using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcViewModelApp.Models
{
    public class Login
    {
        public int Regid{set;get;}
        public string email{set;get;}
        public string password{set;get;}
        public virtual ICollection<Login>Logins{set;get;}
    }
}