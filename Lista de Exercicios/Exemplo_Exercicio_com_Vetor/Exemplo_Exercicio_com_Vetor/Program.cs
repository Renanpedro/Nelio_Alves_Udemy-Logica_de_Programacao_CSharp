using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exemplo_Exercicio_com_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Informe um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Os números informados foram: ");
                Console.WriteLine(vet[i].ToString("F1"), CultureInfo.InvariantCulture);
            }

            Console.ReadKey();

        }
    }
}
