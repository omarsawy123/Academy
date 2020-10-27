using System;
using System.ComponentModel.DataAnnotations;

namespace Academy_Models
{
    public class Student
    {

        public int id { get; set; }

        [Required]
        [MinLength(3,ErrorMessage ="Name too short")]
        [MaxLength(20,ErrorMessage ="Name too long")]
        public string name { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        
        public AcademicYear AcademicYear { get; set; }

        [Required]
        public string Description { get; set; }
    }
}