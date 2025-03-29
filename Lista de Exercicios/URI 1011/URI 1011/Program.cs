using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, VolumeEsfera;
            pi = 3.14159;

            raio = double.Parse(Console.ReadLine());
            VolumeEsfera = (4 / 3.0) * pi * (Math.Pow(raio, 3));

            Console.WriteLine(VolumeEsfera.ToString("F3"), CultureInfo.InvariantCulture);

            Console.ReadKey();

        }
    }
}
