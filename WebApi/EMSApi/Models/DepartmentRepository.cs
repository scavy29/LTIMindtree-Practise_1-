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
        public void DeleteDepartment(int id)
        {
            Department department=context.Departments.Find(id);
            context.Departments.Remove(department);
            context.SaveChanges();
        }
        public void EditDepartment(Department dept)
        {
            Department department=context.Departments.Find(dept.Id);
            department.DeptName=dept.DeptName;
            context.SaveChanges();
        }
        public Department FindDept(int id)
        {
            var data=context.Departments.Find(id);
            return data;
        }
        public List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }
    }
}