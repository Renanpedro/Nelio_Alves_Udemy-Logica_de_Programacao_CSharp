using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetoresParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double[] pares = new double[n];
            double[] impares = new double[n];
            double[] numeroDigitado = new double[n];

            

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Por gentileza informar o {0} número: ", i);
                numeroDigitado[i] = double.Parse(Console.ReadLine());

                while (numeroDigitado[i] == 0) {
                    Console.WriteLine("Por gentileza informar um número diferente de zero!!");
                    Console.WriteLine("Por gentileza informar o {0} número: ", i);
                    numeroDigitado[i] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (numeroDigitado[i] % 2 == 0) {
                    pares[i] = numeroDigitado[i];
                } else
                {
                    impares[i] = numeroDigitado[i];
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("Os números pares informados são: ");

            for (int i = 0; i < n; i++) {
                if (pares[i] != 0) {
                    Console.Write(pares[i] + " ");
                }              
            }

            Console.WriteLine(" ");
            Console.WriteLine("Os números impares informados são: ");

            for (int i = 0; i < n; i++)
            {
                if (impares[i] != 0) {
                    Console.Write(impares[i] + " ");
                }                
            }

            Console.ReadKey();
        }
    }
}
