using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] valoresX = Console.ReadLine().Split(' ');
            x1 = double.Parse(valoresX[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valoresX[1], CultureInfo.InvariantCulture);

            string[] valoresY = Console.ReadLine().Split(' ');
            x2 = double.Parse(valoresY[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valoresY[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1 , 2.0));

            Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
