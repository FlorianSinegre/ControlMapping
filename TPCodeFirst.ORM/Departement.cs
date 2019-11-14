using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCodeFirst.ORM
{
        public  class Departement
    {
        [Key]
        public int DepartementID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public float Budget { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
