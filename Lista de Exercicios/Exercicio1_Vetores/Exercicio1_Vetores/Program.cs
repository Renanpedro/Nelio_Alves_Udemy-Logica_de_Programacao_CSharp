using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;

            Console.WriteLine("Quantos números deseja informar? ");
            n = int.Parse(Console.ReadLine());

            vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Informe um número por gentileza: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os números negativos informados foram: ");

            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);    
                }
            }

            Console.ReadKey();
        }
    }
}
