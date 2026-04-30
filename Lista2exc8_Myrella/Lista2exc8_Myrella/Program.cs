using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc8_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                if (a * a == b * b + c * c)
                    Console.WriteLine("Forma um triângulo retângulo");
                else
                    Console.WriteLine("Não forma um triângulo retângulo");
            }
            else if (b >= a && b >= c)
            {             
                if (b * b == a * a + c * c)
                    Console.WriteLine("Forma um triângulo retângulo");
                else
                    Console.WriteLine("Não forma um triângulo retângulo");
            }
            else
            {           
                if (c * c == a * a + b * b)
                    Console.WriteLine("Forma um triângulo retângulo");
                else
                    Console.WriteLine("Não forma um triângulo retângulo");
            }
        }
    }
}
