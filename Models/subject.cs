using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMangmentSystemCore.Models
{
    public class subject
    {

        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public int MaxStudents { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual List<student> Students { get; set; }
    }
}
