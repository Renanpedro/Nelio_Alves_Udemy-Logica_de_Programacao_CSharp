using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico_Matriz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Quantas colunas e linhas terá a sua matriz? ");
            n = int.Parse(Console.ReadLine());

            
            double[,] matriz = new double[n, n];

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    matriz[i, j] = double.Parse(s[j]);
                }
            }

            Console.WriteLine("Diagnonal principal: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(matriz[i,i] + " ");
            }

            int cont = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] < 0) {
                        cont++;
                    }
                }
            }

            Console.WriteLine("Negativos: " + cont);
            Console.ReadKey();

        }
    }
}
