using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace E_learning.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string ManagerID { get; set; } // Id của manager
        public IdentityUser Manager { get; set; }
        public ICollection<Class> Class { get; set; }
    }
}
