using System;
using System.Globalization;

namespace Exercicio_Vetores_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double maiorAltura = 0, cont = 0, contMulheres = 0,
                alturaTotalMulheres = 0, mediaAlturaMulheres;

            Console.WriteLine("Quantos números deseja informar: ");
            n = int.Parse(Console.ReadLine());

            double[] altura = new double[n];
            string[] sexo = new string[n];

            for (int i = 0; i < n; i++) {
                string[] vetor = Console.ReadLine().Split(' ');

                altura[i] = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                sexo[i] = (vetor[1]);
            }

            for (int i = 0; i < n; i++) {
                if (altura[i] > maiorAltura) { 
                    maiorAltura = altura[i];
                }
            }

            double menorAltura = altura[0];

            for (int i = 0; i < n; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (sexo[i] == "F")
                {
                    alturaTotalMulheres += altura[i];
                    contMulheres++;
                }
                else {
                    cont++;
                }
            }

            mediaAlturaMulheres = alturaTotalMulheres / contMulheres;

            Console.WriteLine(" ");

            Console.WriteLine("A menor altura é: " + menorAltura.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("A maior altura é: " + maiorAltura.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("A média da altura das mulheres é: " + mediaAlturaMulheres.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("O número de homens é: " + cont);

            Console.ReadKey();

        }
    }
}
