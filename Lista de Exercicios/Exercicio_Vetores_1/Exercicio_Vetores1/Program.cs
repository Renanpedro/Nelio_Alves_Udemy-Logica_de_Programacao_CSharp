using System;
using System.Globalization;

namespace Exercicio_Vetores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] numeros;
            double maiornumero = 0 , posicao = 0;

           
            Console.WriteLine("Quantos números deseja informar? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Informe os números na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');

            numeros = new double[n];

            for (int i = 0; i < n; i++) {
                numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }


            for (int i = 0; i < n; i++) {
                if (numeros[i] >= maiornumero) {
                    maiornumero = numeros[i];
                    posicao = i + 1;
                }
            }

            Console.WriteLine("O maior número é: " + maiornumero.ToString("F1"), CultureInfo.InvariantCulture);
            Console.WriteLine("O número está na posição: " + posicao);

            Console.ReadKey();

        }
    }
}
