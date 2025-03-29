using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km;
            double litrosDeGasolina,kilometrosporlitro;

            km = int.Parse(Console.ReadLine());
            litrosDeGasolina = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            kilometrosporlitro = km / litrosDeGasolina;

            Console.WriteLine("O carro está percorrendo " + kilometrosporlitro.ToString("F3"), CultureInfo.InvariantCulture + " KM/L");

            Console.ReadKey();
        }
    }
}
