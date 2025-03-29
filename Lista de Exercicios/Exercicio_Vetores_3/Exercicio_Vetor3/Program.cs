using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Vetor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] numerosVetorA, numerosVetorB, numerosVetorC;

            Console.WriteLine("Quantos números deseja informar? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os " + n + " numeros do primeiro vetor: ");
            string[] vet1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Informe os " + n + " numeros do segundo vetor: ");
            string[] vet2 = Console.ReadLine().Split(' ');

            numerosVetorA = new double[n];
            numerosVetorB = new double[n];
            numerosVetorC = new double[n];

            for (int i = 0; i < n; i++) {
                numerosVetorA[i] = double.Parse(vet1[i]);
                numerosVetorB[i] = double.Parse(vet2[i]);
            }

            for (int i = 0; i < n; i++) {
                numerosVetorC[i] = numerosVetorA[i] + numerosVetorB[i];
            }

            Console.WriteLine("A soma dos valores dos vetores A e B são:");

            for (int i = 0; i < n; i++) {
                Console.Write(numerosVetorC[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
