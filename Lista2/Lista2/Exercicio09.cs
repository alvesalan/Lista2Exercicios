using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lista2
{
    internal class Exercicio09
    {
        public Exercicio09()
        {
            int N1 = 0, N2 = 0, N3 = 0, N4 = 0;

            try
            {
                Console.Write("Numero {0}: ", 1);
                N1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite somente numeros !!");
                Console.Write("Numero {0} novamente: ", 1);
                N1 = Convert.ToInt32(Console.ReadLine());
            }


            try
            {
                Console.Write("Numero {0}: ", 2);
                N2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite somente numeros !!");
                Console.Write("Numero {0} novamente: ", 2);
                N2 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("Numero {0}: ", 3);
                N3 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite somente numeros !!");
                Console.Write("Numero {0} novamente: ", 3);
                N3 = Convert.ToInt32(Console.ReadLine());
            }


            try
            {
                Console.Write("Numero {0}: ", 4);
                N4 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite somente numeros !!");
                Console.Write("Numero {0} novamente: ", 4);
                N4 = Convert.ToInt32(Console.ReadLine());
            }

            if ((N1 == N2) && (N1 == N3) && (N1 == N4))
            {
                Console.WriteLine("Pode ser um quadrado");
            }
            else if ((N2 == N1) && (N2 == N3) && (N2 == N4))
            {
                Console.WriteLine("Pode ser um quadrado");
            }
            else if ((N3 == N1) && (N3 == N2) && (N3 == N4))
            {
                Console.WriteLine("Pode ser um quadrado");
            }


            else if ((N4 == N1) && (N4 == N2) && (N4 == N3))
            {
                Console.WriteLine("Pode ser um quadrado");
            }
            else
            {
                Console.WriteLine("Não pode ser um quadrado");
            }
            Console.ReadKey();
              
        }
    }
}