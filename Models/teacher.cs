using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMangmentSystemCore.Models
{
    public class teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string TechFirstName { get; set; }
        [Required]
        public string TechLastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string mobile { get; set; }
        public virtual List<student> Students { get; set; }

    }
}
