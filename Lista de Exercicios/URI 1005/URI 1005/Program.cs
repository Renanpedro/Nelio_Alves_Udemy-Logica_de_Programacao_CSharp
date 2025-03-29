using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace URI_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, media;
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((a * 3.5) + (b * 7.5)) / 11;

            Console.WriteLine(media.ToString("F5"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
