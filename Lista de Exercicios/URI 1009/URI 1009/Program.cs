using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalVendas, SalarioTotal;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SalarioTotal = (totalVendas * 0.15) + salario;

            Console.WriteLine(SalarioTotal.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
