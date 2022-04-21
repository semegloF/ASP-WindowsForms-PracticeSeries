using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjConCsIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // String nom;
            //  nom = "";

            Single valeur1,valeur2,result;

         

           // Int32 resulat;
           // resulat = valeur1 + valeur2;


            
            
            //Afiiche a l'ecran
            Console.WriteLine("              OPERATEUR DE BASE");
            Console.WriteLine("              ------------------");

            Console.Write("Entrez valeur1 :");
            valeur1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Entrez valeur2 :");
            valeur2 = Convert.ToSingle(Console.ReadLine());

            result = valeur1 + valeur2;

            Console.WriteLine("Addition de" + valeur1 +" et "+valeur2+" est "+ result);

            //Console.Write("Entrez votre nom :");
            //nom= Console.ReadLine();
            // Console.WriteLine("Bonjour "+ nom);






            //permet de laisser le resultat à l'ecran aussi longtemps que possible
            Console.ReadKey();

        }
    }
}
