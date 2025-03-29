using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (((a * 2.0) + (b * 3.0) + (c * 5.0))) / 10.0;

            Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
