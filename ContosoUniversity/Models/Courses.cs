using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Кредиты")]
        public int Credits { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}