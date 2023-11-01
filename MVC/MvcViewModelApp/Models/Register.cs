using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcViewModelApp.Models
{
    public class Register
    {
        public int Regid{set;get;}
        public string email{set;get;}
        public string password{set;get;}
        public int age{set;get;}
        public DateTime DOB{set;get;}

        public virtual Register Registers {set;get;}
    }
}