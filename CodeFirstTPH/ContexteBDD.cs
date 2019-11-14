using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTPH
{
    class ContexteBDD : DbContext
    {
        public ContexteBDD()
            :base("ChaineDeConnexion")
        {

        }
        public DbSet<Animal> Animaux { get; set; }
        public DbSet<Mammifere> Mammiferes { get; set; }
        public DbSet<Oiseau> Oiseaux { get; set; }
    }
}
