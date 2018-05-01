using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Exercicio06
    {
        public Exercicio06()
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
                Console.WriteLine("Voce digitou: (" + ReadLineValue + ") digite apenas numeros porfavor !!");
                Console.Write("Diga um numero: ");
                N = Convert.ToInt32(Console.ReadLine());
                
            }

            if (N != 1)
            {
                Console.WriteLine("O numero e diferente de um");
            }
            else if (N == 1)
            {
                Console.WriteLine("Numero e exatamente 1");
            }

            Console.ReadKey();
        }
    }
}