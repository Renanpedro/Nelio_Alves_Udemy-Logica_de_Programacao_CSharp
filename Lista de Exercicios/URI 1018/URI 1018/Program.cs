using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace URI_1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, n100, n50, n20, n10, n5, n2, n1, resto;

            valor = int.Parse(Console.ReadLine());

            n100 = valor / 100;
            resto = valor % 100;

            n50 = resto / 50;
            resto = 50 % n50;

            n20 = resto / 20;
            resto = 20 % n20;

            n10 = resto / 10;
            resto = 10 % n10;
           
            n5 = resto / 5;
            resto = 5 % n5;

            n2 = resto / 2;
            resto = 2 % n2; ;

            n1 = resto / 1;
            resto = 1 % n1;

            Console.WriteLine(n100);
            Console.WriteLine(n50);
            Console.WriteLine(n20);
            Console.WriteLine(n10);
            Console.WriteLine(n5);
            Console.WriteLine(n2);
            Console.WriteLine(n1);

            Console.ReadKey();
        }
    }
}
