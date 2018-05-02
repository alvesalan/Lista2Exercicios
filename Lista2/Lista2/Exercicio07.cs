using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Exercicio07
    {
        public Exercicio07()
        {
            int N = 0;
            string ReadLineValue = "";

            Console.Write("Diga um numero: ");
            ReadLineValue = Console.ReadLine();

            try
            {
                N = Convert.ToInt32(ReadLineValue);

            }
            catch (Exception)
            {

                Console.WriteLine("Voce digitou (" + ReadLineValue + ") digite apenas numero porfavor !!");
                Console.Write("Digite um numero: ");
                N = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            if (N == 0)
            {
                Console.WriteLine("Numero neutro");
            }
            else if (N % 2 == 0)
            {
                Console.WriteLine("Numero par");
            }
            else if (N % 2 == 1)
            {
                Console.WriteLine("Numero impar");
            }

            if (N >= 0)
            {
                Console.WriteLine("Numero positivo");
            }
            else if (N < 0)
            {
                Console.WriteLine("Numero negativo");
            }

            if (N > 10)
            {
                Console.WriteLine("Numero maior que 10");
            }

            if (N <= 50)
            {
                Console.WriteLine("O numero e menor ou igual a 50");
            }

            if (N < -10)
            {
                Console.WriteLine("Numero menor que -10");
            }

            if (N >= 30)
            {
                Console.WriteLine("Numero e maior ou igual a 30");
            }

            if (N != 1)
            {
                Console.WriteLine("Numero diferente de 1");
            }

            Console.ReadKey();
        }
    }
}