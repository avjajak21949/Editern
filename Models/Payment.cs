using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace E_learning.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public ICollection<Course> Course { get; set; }
        public int StudentID { get; set; } // Id của student
        public Student Student { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ManagerID { get; set; } // Id của manager
        public IdentityUser Manager { get; set; }
        public bool status { get; set; } = false;
    }
}
