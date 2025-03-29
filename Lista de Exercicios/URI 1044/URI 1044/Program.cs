using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não são Multiplos");
            }

            Console.ReadKey();
        }
    }
}
