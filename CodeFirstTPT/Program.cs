using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTPT
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContexteBDD())
            {
                var animaux = db.Animaux;
                foreach (var item in animaux)
                {
                    Console.WriteLine($"Animal : {item.Genre}{item.Espece}");

                }
                Console.ReadKey(); 
            }
        }
    }
}
