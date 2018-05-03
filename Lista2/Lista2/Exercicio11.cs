using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lista2
{
    internal class Exercicio11
    {
        public Exercicio11()
        {
            int N1 = 0, N2 = 0, N3 = 0, N4 = 0, N5 = 0, Media = 0;

            try
            {
                Console.Write("Nota 1: ");
                N1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numero porfavor !!");
                Console.Write("Nota 1: ");
                N1 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("Nota 2: ");
                N2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numero porfavor !!");
                Console.Write("Nota 2: ");
                N2 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("Nota 3: ");
                N3 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numero porfavor !!");
                Console.Write("Nota 3: ");
                N3 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("Nota 4: ");
                N4 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numero porfavor !!");
                Console.Write("Nota 4: ");
                N4 = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("Nota 5: ");
                N5 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numero porfavor !!");
                Console.Write("Nota 5: ");
                N5 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Nota                  Status" +
            "\nDe 0 até 5.99         Reprovado"+
            "\nDe 6.00 até 7.99      Recuperação"+
            "\nAcima de 7.99         Aprovado");
        }
    }
}