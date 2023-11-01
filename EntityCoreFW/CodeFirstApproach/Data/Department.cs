using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    public partial class Department
    {
        public int DepartmentId{set;get;}
        public string? DepartmentName{set;get;}
        public virtual ICollection<Employee>? Employees{set;get;}
    }
}
