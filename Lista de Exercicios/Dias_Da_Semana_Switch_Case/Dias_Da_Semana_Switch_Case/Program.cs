using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_Da_Semana_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            string dia;

            Console.WriteLine("informe um número de 1 a 7:" +
                "");
            entrada = int.Parse(Console.ReadLine());

            switch (entrada) {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "sabádo";
                    break;
                default:
                    dia = "inválido";
                    break;

            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadKey();
        }
    }
}
