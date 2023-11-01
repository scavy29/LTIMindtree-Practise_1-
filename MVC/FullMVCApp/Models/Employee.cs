using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullMVCApp.Models
{
    public class Employee
    {
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}
        public int DepartmentId {set;get;}
        public int Salary{set;get;}
        public DateTime JoinDate{set;get;}
        public bool IsRegular{set;get;}
    }
}