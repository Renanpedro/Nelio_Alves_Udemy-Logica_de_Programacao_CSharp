﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y;


            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y) {
                if (x < y)
                {
                    Console.WriteLine("CRESCENTE");
                }
                else {
                    Console.WriteLine("DECRESCENTE");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

        }
    }
}
