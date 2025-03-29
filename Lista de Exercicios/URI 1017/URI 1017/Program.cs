using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1017
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int tempo, km, velociadeMedia, qtdCombustivel;
            string[] valor = Console.ReadLine().Split(' ');
            
            tempo = int.Parse(valor[0]);
            km = int.Parse(valor[1]);

            velociadeMedia = tempo * km;
            qtdCombustivel = velociadeMedia / 12;

            Console.WriteLine("Foram gastos " + qtdCombustivel + " litros de gasolina");

            Console.ReadKey();
        }
    }
}
