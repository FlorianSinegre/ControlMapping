using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCodeFirst.ORM
{
    public class Person
    {
        [Key]
        public int PeronID { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public int FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime EnrollementID { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public Person()
        {
            Courses = new List<Course>();
        }
    }
}
