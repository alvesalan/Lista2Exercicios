﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Exercicio04
    {
        public Exercicio04()
        {
            int N = 0;

            try
            {
                Console.Write("Me diga um numero: ");
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numero porfavor !!");
                Console.Write("Me diga um numero: ");
                N = Convert.ToInt32(Console.ReadLine());

            }

            if (N == 0)
            {
                Console.WriteLine("Numero neutro");
            }
            else if (N % 2 == 1)
            {
                Console.WriteLine("O numero não e par");
            }
            else if (N % 2 == 0)
            {
                Console.WriteLine("O numero e par");
            }

            Console.ReadKey();

        }
    }
}