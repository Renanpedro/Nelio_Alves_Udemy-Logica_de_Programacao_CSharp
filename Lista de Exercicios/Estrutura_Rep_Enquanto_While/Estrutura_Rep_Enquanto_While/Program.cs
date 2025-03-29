using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Rep_Enquanto_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, soma;
            soma = 0;

            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                soma += x;
                x = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
