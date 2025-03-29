using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_Resolvido_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precometroquadrado, area, preco;

            Console.WriteLine("Informe a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o comprimento do terrno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor do metro quadrado: ");
            precometroquadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = precometroquadrado * area;

            Console.WriteLine("A área do terreno é: " + area.ToString("F2"),CultureInfo.InvariantCulture);
            Console.WriteLine("O preço do terreno é: " + preco.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
