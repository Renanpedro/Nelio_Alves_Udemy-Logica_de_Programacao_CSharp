using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;

            Console.WriteLine("Informe o 1º Número: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("A soma dos valores é: " + X);

            Console.ReadKey();
        }
    }
}
