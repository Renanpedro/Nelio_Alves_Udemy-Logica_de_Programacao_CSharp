using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            x = (a * b - c * d);

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
