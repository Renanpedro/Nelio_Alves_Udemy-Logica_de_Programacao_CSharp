using System;
using System.Data;
using System.Globalization;
using System.IO;

namespace Exercicio23_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] nomes;
            double[] idades;
            double[] alturas;

            Console.WriteLine("Quantos dados deseja informar? ");
            n = int.Parse(Console.ReadLine());

            nomes = new string[n];
            idades = new double[n];
            alturas = new double[n];


            // Leitura dos dados
            for (int i = 0; i < n; i++)
            {
                string[] frase = Console.ReadLine().Split(' ');

                nomes[i] = frase[0];
                idades[i] = double.Parse(frase[1], CultureInfo.InvariantCulture);
                alturas[i] = double.Parse(frase[2], CultureInfo.InvariantCulture);

            }

            //Calculo da altura média
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += alturas[i];
            }

            double media = soma / n;
            Console.WriteLine("Altura média: " + media.ToString("F2"), CultureInfo.InvariantCulture);

            //Calculo da idade com menos de 16 anos
            int cont = 0;
            for (int i = 0; i < n; i++) {
                if (idades[i] < 16) {
                    cont++;
                }
            }

            double porcentagem = (double) cont / n * 100.0;

            Console.WriteLine("pessoas com menos de 16 anos: " + porcentagem.ToString("F1",CultureInfo.InvariantCulture) + "%");

            Console.ReadKey();
        }    
    }
}
