using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Informe um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 0 && numero < 25)
            {
                Console.WriteLine("O número digitado: " + numero + " Se encontra no range de 0 á 25");
            }
            else if (numero > 25.01 && numero < 50)
            {
                Console.WriteLine("O número digitado: " + numero + " Se encontra no range de 25.01 á 50");
            }
            else if (numero > 50.01 && numero < 75)
            {
                Console.WriteLine("O número digitado: " + numero + " Se encontra no range de 50.01 á 70");
            }
            else if (numero > 75.01 && numero < 100)
            {
                Console.WriteLine("O número digitado: " + numero + " Se encontra no range de 75.01 á 100");
            }
            else {
                Console.WriteLine("O número informado não se encontra no range de o á 100");
            }

            Console.ReadKey();

        }
    }
}
