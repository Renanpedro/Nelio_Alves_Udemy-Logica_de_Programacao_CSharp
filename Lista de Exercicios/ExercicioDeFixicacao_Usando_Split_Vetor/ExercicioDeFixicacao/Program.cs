using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDeFixicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, NomeNovamente;
            int quartos, idade;
            double preco, altura;

            Console.WriteLine("Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem a sua casa?");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de um produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe sua nome, idade e altura: ");
            string[] frase = Console.ReadLine().Split(' ');

            NomeNovamente = frase[0];
            idade = int.Parse(frase[1]);
            altura = double.Parse(frase[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua casa tem " + quartos + " quartos");
            Console.WriteLine("O preço do produto informado é: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Segundo nome informado: " + NomeNovamente);
            Console.WriteLine("Idade informada: " + idade);
            Console.WriteLine("Altura informada: " + altura.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
            
        }
    }
}
