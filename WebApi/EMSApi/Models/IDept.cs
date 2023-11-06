using System.Collections.Generic;

namespace EMSApi.Models
{
    public interface IDept
    {
        List<Department> GetDepartments();
        Department FindDept(int id);
        void AddDepartment(Department dept);
        void EditDepartment(Department dept);
        void DeleteDepartment(int id);
    }
}