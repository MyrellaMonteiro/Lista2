using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc7_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Informe o primeiro valor");
            a = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o primeiro valor");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o primeiro valor");
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && c + b > a)

            {
                if (a == b && a == c) { Console.WriteLine("É um triângulo equilátero"); }

                else if ((a == b && a != c) || (a == c && a != b) || (b == c && c != a))
                {
                    Console.WriteLine("É um triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }
        }
    }
}
