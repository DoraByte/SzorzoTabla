using System;

namespace Gyakorlás_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string szam;
            int ertek;
            Console.WriteLine("Adj meg egy számot!");
            szam = Console.ReadLine();
            if (!int.TryParse(szam, out ertek))
            {
                Console.WriteLine("Nem számot adtál meg.");
                Console.ReadKey();
            }

            int szorzat = ertek * 2;
            Console.WriteLine("Szám: {0} * 2 = {1}.", ertek, szorzat);
            Console.ReadKey();
        }
    }
}
