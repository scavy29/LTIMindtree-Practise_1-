using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KathakBooking.Models
{
    public class Student
    {
        public int StudentId{get;set;}
        public string? Name{get;set;}
        
        public string? Email{get;set;}
        public int ClassId{get;set;}
        public Class? Class{get;set;}
    }
}