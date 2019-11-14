using System;
using System.Collections.Generic;
using System.Linq;

namespace cours
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Petite Syntaxe

            //inférence de type
            var entier = 5; //raccourci d'écriture, a la compilation, transforme le type en fonction de ce qu'il y a de l'autre coté du égal.

            //type anonymes => variable dont on a pas le nom 
            var voiture = new
            {
                //directoss les propriétés.
                immatriculation = "EF 333 DD"
                ,
                marque = "Renault"
                ,
                modele = "Talisman"
            };
            Console.WriteLine(voiture.immatriculation);

            //initialisateur d'objet
            //chaton.Nom="dfshgfdshglks"   Comment on ferait normalement
            var chaton = new Chaton()// CTRL + ;  pour generer la classe // cliquer sur Chaton puis F12 pour aller directement sur Chaton
            {
                Nom = "Plume",
                Couleur = "Blanc",
                DateDeNaissance = new DateTime(2009, 7, 15)

            };

            //initialisateur de listes et tableaux
            var Liste = new List<int>() { 5, -3, 6, -8, 2 };
            var tab = new int[] { 5, -3, 6, -8, 2 };

            #endregion

            #region méthodes d'extension   
            var s = "une chaine de caractère";
            /*var code = extension.Crypter(s, "prout");
            var sDecyptee = extension.Decrypter(code, "unMotDePasse");*/
            var code = s.Crypter("mdp");

            var sDecryptee = code.Decrypter("motDePasse");

            #endregion

            #region Generique et delegues

            var l = new Liste<int>();
            l.Ajouter(5);
            l.Ajouter(5);
            l.Ajouter(5);
            l.Ajouter(5);

            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);

            }
            Console.ReadKey();

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

            l.Trier((a, b) => a > b);
            #endregion

            #region INTRO LINQ
            //maintenant que vous avez compris les methodes d'extension, les IEnumerable
            //et les expressions lambda voici LINQ, ca veut dire language INtegrated Query
            // des methodes d'extension sur les IEnumerable qui prennnent en paramètre 
            // des expressions lambda

            var entiers = new int[] { 5, 6, -4, 8, -2 };
            /* var listeNegatifs = new List<int>();
             foreach (var item in entiers)
             {
                 if (item<0)
                 {
                     listeNegatifs.Add(item);
                 }
             }*/

            var listeNegatifs = entiers.Where(item => item < 0).ToList();

            var mesChatons = new List<Chaton>()
            {
                new Chaton(){Nom ="bidule", Couleur="Gris",DateDeNaissance=DateTime.Now}
                , new Chaton(){Nom ="dudule", Couleur="Gris",DateDeNaissance=DateTime.Now}
                , new Chaton(){Nom ="kekette", Couleur="Gris",DateDeNaissance=DateTime.Now}
                , new Chaton(){Nom ="chose", Couleur="Gris",DateDeNaissance=DateTime.Now}
                , new Chaton(){Nom ="zazouuuu", Couleur="blou",DateDeNaissance=DateTime.Now}
                , new Chaton(){Nom ="bidule", Couleur="Gris",DateDeNaissance=DateTime.Now}
                , new Chaton(){Nom ="bidule", Couleur="Gris",DateDeNaissance=DateTime.Now}
                , new Chaton(){Nom ="bidule", Couleur="Gris",DateDeNaissance=DateTime.Now}
            };
            var mesChatonsQuiCommenceParB = mesChatons.Where(c => c.Nom.StartsWith("b"));

            mesChatons.AsParallel().ForAll(c => c.Dormir());
            Console.ReadKey();

            #endregion
        }
    }
}
