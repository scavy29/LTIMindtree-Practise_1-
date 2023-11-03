using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Models
{
    public class Employee
    {
        public int EmployeeId{set;get;}
        public string? EmployeeName{set;get;}
        public double Salary{set;get;}
    }
}