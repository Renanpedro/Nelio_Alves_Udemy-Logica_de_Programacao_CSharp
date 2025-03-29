using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Vetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cont;
            int[] vet;
            int[] vetorPar;
           

            Console.WriteLine("Quantos números deseja informar? ");
            n = int.Parse(Console.ReadLine());

            vet = new int[n];
            

            Console.WriteLine("informe os números: ");
            string[] numeros = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                vet[i] = int.Parse(numeros[i]);
            }

            Console.WriteLine("Os números pares são:");
            cont = 0;
            for (int i = 0; i < n; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(vet[i] + " ");
                    cont++;
                }
            }

          
            Console.WriteLine(" ");
            Console.WriteLine("São " + cont + " números pares");

            Console.ReadKey();
            
        }
    }
}
