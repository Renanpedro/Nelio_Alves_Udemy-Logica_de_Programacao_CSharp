using System;
using System.Globalization;

namespace Exercicio_Vetores_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Quantos números deseja informar: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor informar os " + n + " números: ");
            string[] vet = Console.ReadLine().Split(' ');

            double[] numeros = new double[n];

            for (int i = 0; i < n; i++) {
                numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            double soma = 0, cont = 0;

            for (int i = 0; i < n; i++) {
                if (numeros[i] % 2 == 0) {
                    soma += numeros[i];
                    cont++;
                }
            }

            double media = 0;
            media = soma / cont;

            Console.WriteLine("A média dos números pares é: " + media.ToString("F2"), CultureInfo.InvariantCulture);
            Console.ReadKey();

            
        }
    }
}
