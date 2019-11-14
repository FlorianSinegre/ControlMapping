using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCodeFirst.ORM
{
        public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }

        public Course()
        {
            Persons = new List<Person>();
            StudentGrades = new List<StudentGrade>();
        }
    }
}
