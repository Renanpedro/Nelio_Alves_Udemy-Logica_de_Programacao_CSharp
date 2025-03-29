using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recriandoMusicaDosPatinhos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patinhos, patinhosRestantes;

            Console.Write("Quantos patinhos foram passear? ");
            patinhos = int.Parse(Console.ReadLine());
            patinhosRestantes = patinhos;

            Console.WriteLine(" ");

            for (int i = 0; i < patinhos; i++) {

                Console.WriteLine("{0} patinhos foram passear", patinhosRestantes);
                Console.WriteLine("Além das montanhas");
                Console.WriteLine("Para brincar");
                Console.WriteLine("A mamãe gritou quá quá quá quá");

                patinhosRestantes--;

                Console.WriteLine("Mas só {0} patinhos voltaram de lá", patinhosRestantes);
                Console.WriteLine(" ");
            }

            Console.WriteLine("A mamãe patinha foi procurar");
            Console.WriteLine("Além das Montanhas");
            Console.WriteLine("Na beira do mar");
            Console.WriteLine("A mamãe gritou quá quá quá quá");
            Console.WriteLine("E os {0} patinhos voltaram de lá", patinhos);

            Console.ReadKey();
        }
    }
}
