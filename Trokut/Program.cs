using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double rez;
        programStart:
            Console.WriteLine("Upisite stranice trokuta. Vrijednosti ne smiju biti 0.");
            Console.WriteLine("Upisite stranicu a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite stranicu b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite stranicu c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Stranica nema pravilne vrijednosti");
                goto programStart;
            }
            else
            {
                rez = Math.Pow(a, 2) + Math.Pow(b, 2);
                if (rez == Math.Pow(c, 2))
                {
                    Console.WriteLine("Upisane stranice su stranice pravokutnog trokta.");
                }
                else Console.WriteLine("Uisane stranice nisu stranice pravokutnog trokuta");
            }
            Console.ReadKey();
        }
    }
}
