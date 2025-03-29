using System;
using System.Globalization;

namespace Exercicio_Vetores_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double valorTotalCompra = 0, valorTotalVenda = 0, lucroTotal = 0;

            Console.WriteLine("Quantos produtos você deseja informar? ");
            n = int.Parse(Console.ReadLine());

            string[] produto = new string[n];
            double[] valorDeCompra = new double[n];
            double[] valorDeVenda = new double[n];

            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');

                produto[i] = vet[0];
                valorDeCompra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                valorDeVenda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {
                valorTotalCompra = valorTotalCompra + valorDeCompra[i];
                valorTotalVenda = valorTotalVenda + valorDeVenda[i];
            }

            lucroTotal = valorTotalVenda - valorTotalCompra;

            Console.WriteLine("");
            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Lucro total:" + lucroTotal.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();

        }
    }
}
