using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace E_learning.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        public int TeacherID { get; set; } // Khóa ngoại từ Teacher
        public Teacher Teacher { get; set; }
        public ICollection<Schedule> Schedule { get; set; } // Lịch học của lớp
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ManagerID { get; set; } // Id của manager
        public IdentityUser Manager { get; set; }
        public bool IsOnline { get; set; } = false;
        public string Location { get; set; }
        public string MeetingLink { get; set; }
        public ICollection<ClassStudent> ClassStudent { get; set; }
    }
}
