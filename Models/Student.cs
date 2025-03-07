using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string Password { get; set; }
        public int StudentPhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PasswordHash { get; set; }
        public string ManagerID { get; set; } // Id của manager
        public IdentityUser Manager { get; set; }
        public ICollection<ClassStudent> ClassStudent { get; set; }
    }
}
