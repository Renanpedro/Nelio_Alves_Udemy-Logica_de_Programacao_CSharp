﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A * B;

            Console.WriteLine(X);

            Console.ReadKey();

        }
    }
}
