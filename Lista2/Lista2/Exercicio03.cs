using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Exercicio03
    {
        public Exercicio03()
        {

            double N1 = 0, N2 = 0, Opçao = 0;
            

            try
            {
                Console.Write("Diga um numero: ");
                N1 = Convert.ToInt32(Console.ReadLine());
               
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numeros porfavor !!");
                Console.Write("Diga novamente o numero: ");
                N1 = Convert.ToInt32(Console.ReadLine());

            }


            try
            {
                Console.Write("Diga um numero: ");
                N2 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numeros porfavor !!");
                Console.Write("Diga novamente o numero: ");
                N2 = Convert.ToInt32(Console.ReadLine());

            }


            Console.WriteLine(" _______________________" +
                            "\n| 1       |    Soma     |"+ 
                            "\n| 2       |  Subtrair   |" +
                            "\n| 3       | Multiplicar |" +
                            "\n| 4       |   Dividir   |" +
                            "\n|_________|_____________|");
            Console.WriteLine("");

            try
            {

                Console.Write("Escolha uma opçao: ");
                Opçao = Convert.ToInt32(Console.ReadLine()); 

            }
            catch (Exception)
            {

                Console.WriteLine("Digite apenas numeros porfavor !!");
                Console.Write("Escolha a opçao novamente: ");
                Opçao = Convert.ToInt32(Console.ReadLine());
            }


            if (Opçao == 1)
            {
                Console.WriteLine("Resultado da soma: " + (N1 + N2));
            }
            else if (Opçao == 2)
            {
                Console.WriteLine("Resultado da subtração: " + (N1 - N2));
            }
            else if(Opçao == 3)
            {
                Console.WriteLine("Resultado da multiplicação: " + (N1 * N2));
            }
            else if (Opçao == 4)
            {
                Console.WriteLine("Resultado da divisão: " + (N1 / N2));
            }
           


            Console.ReadKey();
        }
    }
}