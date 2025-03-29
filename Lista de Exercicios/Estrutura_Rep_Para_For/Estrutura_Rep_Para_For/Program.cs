using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Rep_Para_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,x, soma;

            n = int.Parse(Console.ReadLine());
            soma = 0;

            for (int i=0; i < n; i++) {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine(soma);
            Console.ReadKey();

        }
    }
}
