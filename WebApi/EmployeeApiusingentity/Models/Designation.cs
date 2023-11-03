using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApiusingentity.Models
{
    public class Designation
    {
        public int DesignationId{get;set;}
        public string? DesignationName{get;set;}
        public ICollection<Employee>? Employees{get;set;}
    }
}