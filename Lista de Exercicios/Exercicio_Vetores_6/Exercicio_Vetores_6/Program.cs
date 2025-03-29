using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Vetores_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, pessoaMaisVelha = 0, posicaoMaiorIdade = 0; ;

            Console.WriteLine("Quantos nomes + idade você deseja informar? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idadei = new int[n];

            Console.WriteLine(" ");
            Console.WriteLine("Favor informar os dados: ");

            for (int i = 0; i < n; i++) {
                
                string[] vetores = Console.ReadLine().Split(' ');
                nomes[i] = vetores[0];
                idadei[i] = int.Parse(vetores[1]);
            }

            for (int i = 0; i < n; i++) {
                if (idadei[i] > pessoaMaisVelha) {
                    pessoaMaisVelha = idadei[i];
                    posicaoMaiorIdade = i;
                }
            }

            Console.WriteLine("A pessoa mais velha é: " + nomes[posicaoMaiorIdade]);
            Console.ReadKey();


        }
    }
}
