using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            areaTriangulo = (a * c) / 2;
            areaCirculo = (Math.Pow(c, 2)) * 3.14159;
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = Math.Pow(b, 2);
            areaRetangulo = a * b;

            Console.WriteLine(areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
