using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Estrutura_Sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, area, perimetro, diagonal, aElevado, bElevado, raizQuadrada;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = (2 * b) + (2 * a);

            aElevado = Math.Pow(a, 2);
            bElevado = Math.Pow(b, 2);

            raizQuadrada = aElevado + bElevado;

            diagonal = Math.Sqrt(raizQuadrada);

            Console.WriteLine(area.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine(perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine(diagonal.ToString("F4"), CultureInfo.InvariantCulture);

            Console.ReadKey();

        }
    }
}
