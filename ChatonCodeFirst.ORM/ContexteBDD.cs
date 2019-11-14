using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ChatonCodeFirst.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD()
            : base("ChaineDeConnexion")
        {

        } 

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Chaton> Chatons { get; set; }
        public DbSet<Proprietaire> Proprietaires { get; set; }
       

    }
}
