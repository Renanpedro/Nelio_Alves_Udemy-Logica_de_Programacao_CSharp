using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Rep_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fah, celsius;
            string condicao;
            
            do
            {
                Console.WriteLine("Informe o valor de celsius");
                celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                fah = (9 * celsius) / 5 + 32;

                Console.WriteLine("Equivalente em Fahrenheit: " + fah.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Deseja repetir (s/n)?");
                condicao = Console.ReadLine();

            } while (condicao == "s");

            Console.ReadKey();
        }

    }
}
