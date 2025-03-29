using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horainicial, horafinal, duracao;

            Console.WriteLine("Qual a hora inicial do jogo? ");
            horainicial = int.Parse(Console.ReadLine());


            Console.WriteLine("Qual a hora inicial do jogo? ");
            horafinal = int.Parse(Console.ReadLine());

            if (horainicial < horafinal)
            {
                duracao = horafinal - horainicial;
            }
            else {
                duracao = 24 - horainicial + horafinal;
            }

            Console.WriteLine("O jogo durou " + duracao + " Horas");
            Console.ReadKey();
        }
    }
}
