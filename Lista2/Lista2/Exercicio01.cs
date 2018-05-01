using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Exercicio01
    {
        public Exercicio01()
        {
            string ReadLineValue = "";
            int Numero = 0;

               Console.Write("Diga um numero: ");

            try
            {

                ReadLineValue = Console.ReadLine();
                Numero = Convert.ToInt32(ReadLineValue);

                

            }
            catch (Exception error)
            {
                
                Console.WriteLine("Voce digitou ("+ ReadLineValue + ") digite apenas numero." + error);
                Console.Write("Diga um numero: ");
                Numero = Convert.ToInt32(Console.ReadLine());
               

            }

            if (Numero == 0)
            {
                Console.WriteLine("Numero neutro");
            }
            else if (Numero > 0)
            {
                Console.WriteLine("Numero positivo");
            }
            else if(Numero < 0)
            {
                Console.WriteLine("Numero não e positivo");
            }
            Console.ReadKey();
        }
    }
}