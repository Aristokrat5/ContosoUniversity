using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Имя")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Фамилия")]
        public string FirstMidName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Дата поступления")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
