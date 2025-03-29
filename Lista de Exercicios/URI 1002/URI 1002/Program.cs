using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, pi, raio;
            pi = 3.14159;

            Console.WriteLine("Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (raio * 2) * pi;

            Console.WriteLine("A ÁREA É: " + area.ToString("F4"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
