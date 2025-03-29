using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, maior;
            string[] valores = Console.ReadLine().Split(' ');
            n1 = int.Parse(valores[0]);
            n2 = int.Parse(valores[1]);
            n3 = int.Parse(valores[2]);

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior é o: " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("Maior é o: " + n2);
            }
            else {
                Console.WriteLine("Maior é o: " + n3);
            }

            Console.ReadKey();
        }
    }
}
