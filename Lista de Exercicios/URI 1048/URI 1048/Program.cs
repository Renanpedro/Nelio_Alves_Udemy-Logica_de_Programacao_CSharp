using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario;

            Console.WriteLine("Informe o seu salário atual: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                novoSalario = (salario * 0.15) + salario;
                Console.WriteLine("Seu novo salario com ajuste de 15% é: " + novoSalario);
            } else if (salario >= 400.01 && salario <= 800.00) {
                novoSalario = (salario * 0.12) + salario;
                Console.WriteLine("Seu novo salario com ajuste de 12% é: " + novoSalario);
            } else if (salario >= 800.01 && salario <= 1200.00) {
                novoSalario = (salario * 0.10) + salario;
                Console.WriteLine("Seu novo salario com ajuste de 10% é: " + novoSalario);
            } else if (salario >= 1200.01 && salario <= 2000.00) {
                novoSalario = (salario * 0.07) + salario;
                Console.WriteLine("Seu novo salario com ajuste de 7% é: " + novoSalario);
            } else if (salario > 2000.00) {
                novoSalario = (salario* 0.04) + salario;
                Console.WriteLine("Seu novo salario com ajuste de 4% é: " + novoSalario);
            }

            Console.ReadKey();
}           
        
    }
}
