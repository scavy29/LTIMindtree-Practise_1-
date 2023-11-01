using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcApp.Models
{
    public class Employee
    {
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}
        public decimal Salary{set;get;}

        public DateTime JoinDate{set;get;}
    }
}
