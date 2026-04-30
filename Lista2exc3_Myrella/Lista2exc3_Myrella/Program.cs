using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc3_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b;
            int c;
            while (a != 69)
            {
                Console.WriteLine("Indique o primeiro valor: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique o segundo valor: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique o terceiro valor: ");
                c = int.Parse(Console.ReadLine());

                if (a == b && b == c)
                {
                    Console.WriteLine("Todos os valores são iguais");
                }
                else if (a == b && a > c)
                {
                    Console.WriteLine("O 1º e o 2º valor são maiores");
                }
                else if (a == c && a > b)
                {
                    Console.WriteLine("O 1º e o 3º valor são maiores");
                }
                else if (b == c && b > a)
                {
                    Console.WriteLine("O 2º e o 3º valor são maiores");
                }
                else if (a > b && a > c)
                {
                    Console.WriteLine("O 1º valor é maior");
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine("O 2º valor é maior");
                }
                else
                {
                    Console.WriteLine("O 3º valor é maior");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
