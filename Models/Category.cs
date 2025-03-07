using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace E_learning.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManagerID { get; set; } // Id của manager
        public IdentityUser Manager { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}
