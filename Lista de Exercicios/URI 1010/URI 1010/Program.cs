using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codpeca1, codpeca2, qtd1, qtd2;
            double valorpeca1, valorpeca2, valorPago, valortoalitem1, valortotalitem2;


            string[] peca1 = Console.ReadLine().Split(' ');
            codpeca1 = int.Parse(peca1[0]);
            qtd1 = int.Parse(peca1[1]);
            valorpeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            valortoalitem1 = qtd1 * valorpeca1;


            string[] peca2 = Console.ReadLine().Split(' ');
            codpeca2 = int.Parse(peca2[0]);
            qtd2 = int.Parse(peca2[1]);
            valorpeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
            valortotalitem2 = qtd2 * valorpeca2;

            valorPago = valortoalitem1 + valortotalitem2;

            Console.WriteLine(valorPago.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
