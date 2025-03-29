using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frase = Console.ReadLine().Split(' ');
            double idade1, idade2, mediaIdade;

            idade1 = double.Parse(frase[1], CultureInfo.InvariantCulture);
            idade2 = double.Parse(frase[3], CultureInfo.InvariantCulture);

            mediaIdade = (idade1 + idade2) / 2;

            Console.WriteLine("A Idade média de " + frase[0] + " e " + frase[2] + " é de " + mediaIdade.ToString("F1"),CultureInfo.InvariantCulture + " anos" );

            Console.ReadKey();
        }
    }
}
