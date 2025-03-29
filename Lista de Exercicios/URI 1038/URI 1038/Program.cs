using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double codigo, qtd, total, entrada;


            Console.WriteLine("Código 1 - Cachorro Quente - R$4.00");
            Console.WriteLine("Código 2 - x-salada - R$4.50");
            Console.WriteLine("Código 3 - x-bacon  - R$5.00");
            Console.WriteLine("Código 4 - torrada simples - R$2.00");
            Console.WriteLine("Código 5 - refrigerante - R$1.50");

            Console.WriteLine(" ");

            Console.Write("Escolha algum dos itens acima de acordo com o seu código:");
            entrada = double.Parse(Console.ReadLine());

            

            switch (entrada) {
                case 1:
                    Console.Write("Quantos cachorros quentes você deseja?");
                    qtd = double.Parse(Console.ReadLine());
                    total = qtd * 4.00;

                    Console.WriteLine("A sua compra deu: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
                    break;

                case 2:
                    Console.Write("Quantos x-salada  você deseja?");
                    qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = qtd * 4.50;

                    Console.WriteLine("A sua compra deu: R$" + total);
                    break;

                case 3:
                    Console.Write("Quantos x-bacon  você deseja?");
                    qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = qtd * 5.00;

                    Console.WriteLine("A sua compra deu: R$" + total);
                    break;

                case 4:
                    Console.Write("Quantas torradas simples você deseja?");
                    qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = qtd * 2.00;

                    Console.WriteLine("A sua compra deu: R$" + total);
                    break;

                case 5:
                    Console.Write("Quantos refrigerantes você deseja?");
                    qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = qtd * 1.50;

                    Console.WriteLine("A sua compra deu: R$" + total);
                    break;

                default:
                    Console.WriteLine("Não existe este código de produto");
                    break;
            }

            Console.ReadKey();
        }
    }
}
