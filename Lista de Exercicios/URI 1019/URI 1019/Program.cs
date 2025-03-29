using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace URI_1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, segundos, minutos, horas, resto;

            n = int.Parse(Console.ReadLine());
            
            horas = n / 3600;
            resto = n % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            

            Console.ReadKey();
        }
    }
}
