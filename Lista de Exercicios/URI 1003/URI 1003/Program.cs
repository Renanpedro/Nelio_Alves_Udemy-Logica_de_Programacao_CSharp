﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine(soma);

            Console.ReadKey();
        }
    }
}
