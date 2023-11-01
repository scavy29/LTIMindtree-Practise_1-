using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    public partial class Employee
    {
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}
        public int DepartmentId{set;get;}
        public double Salary{set;get;}
        public int Age{set;get;}
        public DateTime JoinDate{set;get;}
        public virtual Department? Department{set;get;}
    }
}

