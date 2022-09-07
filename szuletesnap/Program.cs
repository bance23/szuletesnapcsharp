using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuletesnap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia! Hány emberen vizsgáljuk az esélyeket?");
            int emberszam = Convert.ToInt32(Console.ReadLine());

            double tarolo = 0;

            for (int i = 0; i < emberszam; i++)
            {
                tarolo = tarolo + i;
                Console.WriteLine(tarolo);
            }

            double esely = tarolo / 3.65;
            Console.WriteLine(esely);
            Console.WriteLine("{0} embernél {1} % esély van rá, hogy van két olyan ember akik ugyanazon a napon ünneplik a születésnapjukat.");

            Console.ReadKey();
        }
    }
}
