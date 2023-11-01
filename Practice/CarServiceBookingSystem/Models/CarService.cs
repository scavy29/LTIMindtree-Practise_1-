using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarServiceBookingSystem.Models
{
    public partial class CarService
    {
        [Key]
        public int CarId{get;set;}
        public string? CarName{get;set;}
        public string? CarNumber{get;set;}
        public string? CarVariant{get;set;}
        public string? CustomerName{get;set;}
        public string? Complaint{get;set;}
        public string? PhoneNumber{get;set;}
        public string? Address{get;set;}
    }
}