using System.Collections.Generic;
using System.Linq;

namespace EMSApi.Models
{
    public class DepartmentRepository:IDept
    {
        NewEmpDbContext context=new NewEmpDbContext();

        public void AddDepartment(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
    }
}