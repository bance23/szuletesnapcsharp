using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szulinapgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia! Hány emberen vizsgáljuk az szimulációt?");
            int emberszam = Convert.ToInt32(Console.ReadLine()); Random random = new Random();

            int[] szulinapok = new int[emberszam];

            for (int i = 0; i < szulinapok.Length; i++)
            {
                szulinapok[i] = random.Next(1,366);
                Console.WriteLine(szulinapok[i]);
            }

            for (int i = 0; i < szulinapok.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < szulinapok.Length; j++)
                {

                    if (szulinapok[i] == szulinapok[j])
                        count = count + 1;
                }
                if (count > 1)
                Console.WriteLine(count + "embernek ugyanakkor ünnepli a születésnapját.");
            }



            Console.ReadKey();
        }
    }
}
