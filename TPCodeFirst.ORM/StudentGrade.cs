using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCodeFirst.ORM
{
    public class StudentGrade
    {
        [Key]
        public int EnrollementID { get; set; }
        [Required]
        
       
        public int Grade { get; set; }

        /*public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Person> Persons { get; set; }*/

    }
}
