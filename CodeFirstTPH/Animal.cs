using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTPH
{
        public class Animal
    {
        public int ID { get; set; }
        public bool Male { get; set; }
        public bool Femelle { get; set; }

        [StringLength(50)]
        [Required]
        public string Genre { get; set; }
        [StringLength(50)]
        [Required]
        public string Espece { get; set; }


    }
}
