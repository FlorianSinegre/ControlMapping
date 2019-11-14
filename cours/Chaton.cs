using System;

namespace cours
{
    internal class Chaton
    {
        public string Nom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Couleur { get; set; }
        
        public void Dormir()
        {
            Console.WriteLine($"{Nom} dort...");
            //j'endors le thread
            System.Threading.Thread.Sleep(2000);
        }
    }
}
