using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kathakbooking.Models
{
    public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Foreign key reference to Class entity
    public int ClassID { get; set; }
    public Class Class { get; set; }
}

}