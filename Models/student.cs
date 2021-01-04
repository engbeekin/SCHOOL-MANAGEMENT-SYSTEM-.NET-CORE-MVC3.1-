using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMangmentSystemCore.Models
{
    public class student
    {

        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }

        public int? TeacherId { get; set; }
        public virtual teacher Teacher { get; set; }

        public int? SubjectId { get; set; }
        public virtual subject Subject { get; set; }
    }
}
