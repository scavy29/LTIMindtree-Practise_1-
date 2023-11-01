using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCodeFirstApp.Data
{
    public class Employee
    {
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}
        public int DepartmentId{set;get;}
        public double Salary{set;get;}
        public DateTime JoinDate{set;get;}

        public virtual Department Department{set;get;}
    }
}