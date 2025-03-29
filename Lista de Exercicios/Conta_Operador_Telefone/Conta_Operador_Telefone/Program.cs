using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Operador_Telefone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minutos, conta, resultado;

            minutos = double.Parse(Console.ReadLine());
            conta = 50.0;

            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
                Console.WriteLine("Valor a pagar: " + conta);
            }
            else {
                Console.WriteLine("Valor a pagar: " + conta);
            }
            Console.ReadKey();
        }
    }
}
