using System;
using System.Collections.Generic;

namespace EMSApi.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public int DepartmentId { get; set; }

    public double Salary { get; set; }

    public virtual Department Department { get; set; } = null!;
}
