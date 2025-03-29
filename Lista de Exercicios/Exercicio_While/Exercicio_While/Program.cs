using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, x ,media, soma;
            x = 0;
            soma = 0;

            idade = double.Parse(Console.ReadLine());
            while (idade >=  0) {
                soma +=idade;
                x++;
                idade = double.Parse(Console.ReadLine());
                
             }
            if (x == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                media = soma / x;
                Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
            }
            Console.ReadKey();
        }
    }
}
