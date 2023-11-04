using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiProject.Models
{
    public class Department
    {
        public int DepartmentId{get;set;}
        public string? DeptName{get;set;}
        public ICollection<Employee>? Employees{get;set;}
    }
}