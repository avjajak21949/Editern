using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System;

namespace E_learning.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public int TeacherPhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PasswordHash { get; set; }
        public string ManagerID { get; set; } // Id của manager
        public IdentityUser Manager { get; set; }
        public ICollection<Class> Classe { get; set; }
    }
}
