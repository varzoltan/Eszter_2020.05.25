using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._05._25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Switch case fajta elágazás
            Console.Write("Kérem adjon meg egy jegyet 1-5 között: ");
            int jegy = int.Parse(Console.ReadLine());
            switch (jegy)
            {
                case 1: 
                    Console.WriteLine("Elégtelen osztályzatot kapott!");
                    break;//Minde case lefutása után ki kell lépni!!!
                case 2: 
                    Console.WriteLine("Elégséges osztályzatot kapott!");
                    break;
                case 3: 
                    Console.WriteLine("Közepes osztályzatot kapott!");
                    break;
                case 4:
                    Console.WriteLine("Jó osztályzatot kapott!");
                    break;
                case 5:
                    Console.WriteLine("Jeles osztályzatot kapott!");
                    break;
                
                default: 
                    Console.WriteLine("Az osztályzat nem 1 - 5 közötti szám!");
                    break;
            }

            Console.Write("Adja meg a dolgozat eredményét %-os formában: ");
            int szazalek = Convert.ToInt32(Console.ReadLine());
            int jegy1 = -1;
            if (szazalek >= 0 && szazalek < 50) jegy1 = 1;
            if (szazalek >= 50 && szazalek < 65) jegy1 = 2;
            if (szazalek >= 65 && szazalek < 80) jegy1 = 3;
            if (szazalek >= 80 && szazalek < 90) jegy1 = 4;
            if (szazalek >= 90 && szazalek < 101) jegy1 = 5;
            
            switch (jegy1)
            {
                case 1: Console.WriteLine("Elégtelen osztályzatot kapott!"); break;
                case 2: Console.WriteLine("Elégséges osztályzatot kapott!"); break;
                case 3: Console.WriteLine("Közepes osztályzatot kapott!"); break;
                case 4: Console.WriteLine("Jó osztályzatot kapott!"); break;
                case 5: Console.WriteLine("Jeles osztályzatot kapott!"); break;
                default: Console.WriteLine("Az osztályzat nem 1 - 5 közötti szám!"); break;
            }

            //1.feladat: Kérj be egy egész számot a felhasználótól, és írd ki a nullától való távolságát!
            Console.Write("Kérem adjon meg egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A szám nullától való távolsága: {Math.Abs(szam)}");
            */
            //2.feladat: Sorsolj ki 3 egész számot a [0;10] intervallumból, és írd ki az átlagukat!
            //Egész számok generálása a Random osztállyal
            Random veletlen = new Random();
            int szam1 = veletlen.Next(11);
            int szam2 = veletlen.Next(11);
            int szam3 = veletlen.Next(11);
            double atlag = (szam1 + szam2 + szam3) / 3.0;
            Console.WriteLine($"A véletlenszám: {szam1} {szam2} {szam3}: {Math.Round(atlag,2)}");

            //3.feladat: Sorsolj ki egy egész számot az [1;100] intervallumból, és írd ki, milyen számjegyre végződik!
            szam1 = veletlen.Next(1,101);
            int egyesek = szam1 % 10;
            Console.WriteLine($"1 - 100 közötti véletleszám: {szam1}, mely {egyesek} számjegyre végződik");
            Console.ReadKey();
        }
    }
}
