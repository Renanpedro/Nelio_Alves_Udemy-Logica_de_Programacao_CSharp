using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace URI_1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, exame, mediaexame;

            Console.WriteLine("Informe a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota: ");
            n4 = double.Parse(Console.ReadLine());

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado, parabéns");
            }
            else if (media > 5.0 && media < 6.9) {
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("");
                Console.WriteLine("Informe a nota tirada no exame: ");
                exame = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame " + exame + " Iremos recalcular a média do aluno");
                mediaexame = (media + exame) / 2;
                if (mediaexame > 5.0)
                {
                    Console.WriteLine("Aluno aprovado, média final: " + mediaexame);
                } else {
                    Console.WriteLine("Aluno reprovado, média final: " + mediaexame);
                }
            }

            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado");
            }

            Console.ReadKey();
        }
    }
}
