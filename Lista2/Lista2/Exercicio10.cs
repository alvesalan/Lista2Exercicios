using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Exercicio10
    {
        public Exercicio10()
        {
            int numero1 = 0, numero2 = 0, numero3 = 0, numero4 = 0;

            Console.WriteLine("     __________________");
            Console.WriteLine("     |                |");
            Console.WriteLine("     |                |");
            Console.WriteLine("     |________________|");

            try
            {
                    Console.Write("1° Número: ");
                   numero1 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numeros !!");
                Console.Write("1° Número: ");
                 numero1 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("2° Número: ");
                 numero2 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numeros !!");
                Console.Write("2° Número: ");
                 numero2 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("3° Número: ");
                 numero3 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numeros !!");
                Console.Write("3° Número: ");
                 numero3 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("4° Número: ");
                 numero4 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numeros !!");
                Console.Write("4° Número: ");
                 numero4 = Convert.ToInt32(Console.ReadLine());
            }
            if ((numero1 != numero4) && (numero2 != numero3))
            {
                Console.WriteLine("Pode ser um retangulo");
            }
            else if ((numero1 == numero4) && (numero2 == numero3))
            {
                Console.WriteLine("Não pode ser um retangulo");
            }

            Console.ReadKey();
        }
    }
}