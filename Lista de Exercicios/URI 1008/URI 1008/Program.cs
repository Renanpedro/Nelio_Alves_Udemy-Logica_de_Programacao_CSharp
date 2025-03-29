using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, horastrabalhadas;
            double valorPorHora,Salario;

            numero = int.Parse(Console.ReadLine());
            horastrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = horastrabalhadas * valorPorHora;

            Console.WriteLine(numero);
            Console.WriteLine(Salario.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();

            
        }
    }
}
