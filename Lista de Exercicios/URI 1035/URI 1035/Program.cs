using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if (b > c && d > a && c + d > a + b && c + d >= 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores Aceitos");
            }
            else {
                Console.WriteLine("Valores não aceitos");
            }

            Console.ReadKey();
        }
    }
}
