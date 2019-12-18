using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {

            Personne p1 = new Personne("Madani");
            Stagiaire s1 = new Stagiaire("Chami");
            Formateur f1 = new Formateur("ESSARRAJ");


            Console.WriteLine(p1);
            Console.WriteLine(s1);
            Console.WriteLine(f1);

            

            Console.ReadKey();
        }
    }
}
