using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Exercicio02
    {
        public Exercicio02()
        {
            string ReadLineValue = "";
            int Numero = 0;

            Console.Write("Diga um numero: ");

            try
            {
                ReadLineValue = Console.ReadLine();
                Numero = Convert.ToInt32(ReadLineValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Você digitou (" + ReadLineValue + ") digite apenas numero !");
                Console.Write("Diga um numero: ");
                Numero = Convert.ToInt32(Console.ReadLine());
                
            }

            if (Numero == 0)
            {
                Console.WriteLine("Numero neutro");
            }
            else if (Numero < 0)
            {
                Console.WriteLine("Numero negativo");
            }
            else if (Numero > 0)
            {
                Console.WriteLine("Numero não e negativo");
            }

            Console.ReadKey();
        }
    }
}