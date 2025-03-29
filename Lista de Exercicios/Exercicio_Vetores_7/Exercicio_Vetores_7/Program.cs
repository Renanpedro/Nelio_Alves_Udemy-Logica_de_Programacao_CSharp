using System;
using System.Globalization;
namespace Exercicio_Vetores_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Quantos alunos você deseja calcular? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Favor informar os dados abaixo, nome, n1 e n2");

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            double[] media = new double[n];

            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                
                nome[i] = vet[0];
                nota1[i] = double.Parse(vet[1], CultureInfo.InvariantCulture) ;                               
                nota2[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);                              
                media[i] = (nota1[i] + nota2[i]) / 2;

            }

            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < n; i++) {
                if (media[i] >= 6.0) {
                    Console.WriteLine(nome[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
