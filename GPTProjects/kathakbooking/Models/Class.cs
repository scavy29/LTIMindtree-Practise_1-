using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kathakbooking.Models
{
    public class Class
{
    public int ClassID { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int Capacity { get; set; }

    // Collection navigation property for enrolled students
    public ICollection<Student> EnrolledStudents { get; set; }
}
}