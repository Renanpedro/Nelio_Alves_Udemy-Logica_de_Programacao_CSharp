using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Informe o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }

            Console.ReadKey();
        }
    }
}
