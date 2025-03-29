using System;
using System.Globalization;

namespace Exercicio_Vetores_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double soma = 0,media = 0;

            Console.WriteLine("Quantos números deseja informar: ");
            n = int.Parse(Console.ReadLine());

            double[] numeros = new double[n];

            Console.WriteLine("Favor informar os " + n + " números");
            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {
                soma += numeros[i];
            }

            Console.WriteLine(" ");

            media = soma / n;
            Console.WriteLine("A média dos números é: " + media.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine(" ");

            Console.WriteLine("Os numeros abaixo da média são: ");
            for (int i = 0; i < n; i++) {
                if (numeros[i] < media) {
                    Console.Write(numeros[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
