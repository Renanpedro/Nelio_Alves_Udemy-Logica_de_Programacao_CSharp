using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;
            double soma, media;
            soma = 0;

            Console.WriteLine("Quantos números deseja informar? ");
            n = int.Parse(Console.ReadLine());

            vet = new double[n];

            Console.WriteLine("Por gentileza informar " + n + " números:");
            string[] numeros = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(numeros[i],CultureInfo.InvariantCulture);
                soma += vet[i];
            }

            Console.WriteLine(" ");

            media = soma / n;

            for (int i = 0; i < n; i++) {
                Console.Write(vet[i].ToString("F1"),CultureInfo.InvariantCulture + " " + " ");
            }

            Console.WriteLine(" ");

            Console.WriteLine("A soma dos números é: " + soma.ToString("F1"), CultureInfo.InvariantCulture);
            Console.WriteLine("A média dos números é: " + media.ToString("F1"), CultureInfo.InvariantCulture);

            Console.ReadKey();            


        }
    }
}
