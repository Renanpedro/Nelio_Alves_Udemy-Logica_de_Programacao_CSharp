using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, qtdminutos;

            entrada = int.Parse(Console.ReadLine());

            qtdminutos = (60 * entrada) / 30;

            Console.WriteLine(qtdminutos + " Minutos");

            Console.ReadKey();
        }
    }
}
