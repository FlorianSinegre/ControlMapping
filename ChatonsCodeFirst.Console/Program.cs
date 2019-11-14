using ChatonCodeFirst.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatonsCodeFirst.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new ContexteBDD())
            {
                var categories = db.Categories.Where(c => c.Nom.StartsWith("M"));
                foreach (var item in categories)
                {
                    System.Console.WriteLine(item.Nom);

                }
                var chaton = new Chaton()
                {
                    Categorie = db.Categories.Find(1),
                    Nom = "Minou",
                    Sterilise = false,
                    DateDeNaissance = DateTime.Now,
                };
                var henry = new Proprietaire() { Nom = "Bartonnier", Prenom = "Henry" };
                chaton.Proprietaires.Add(henry);

                db.Chatons.Add(chaton);

                db.SaveChanges();

                System.Console.ReadKey();

              
            }
        }
    }
}
