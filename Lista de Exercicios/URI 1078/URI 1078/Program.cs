using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, valor;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                valor = i * n;
                Console.WriteLine(i + " x " + n + " = " + valor);
            }

            Console.ReadKey();
        }
    }
}
