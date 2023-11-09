using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KathakBooking.Models
{
    public class Class
    {
        public int ClassId{get;set;}
        public DateTime StartTime{get;set;}
        public DateTime EndTime{get;set;}
        [Range(0,10,ErrorMessage="Capacity is 10")]
        public int Capacity{get;set;}
        public ICollection<Student>Students{get;set;}
    }
}