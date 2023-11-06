﻿using System;
using System.Collections.Generic;

namespace EMSApi.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DeptName { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
