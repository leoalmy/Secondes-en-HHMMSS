using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjetSaisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir la un nombres en secondes supérieur à 3600");
            int sec = Convert.ToInt32(Console.ReadLine());
            int heure = sec / 3600;
            sec = sec % 3600;
            int min = sec / 60;
            sec = sec % 60;
            Console.WriteLine(heure + "h" + min + "m" + sec + "s");
            Console.ReadKey();
        }
    }
}
