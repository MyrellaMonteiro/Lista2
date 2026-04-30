using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc4_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int h;

            Console.WriteLine("Indique o valor da base: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique o valor da altura: ");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("A area do retângulo é ");
            a = b * h;
            Console.WriteLine(a);
        
            if (a >= 100) 
            {
                Console.WriteLine("Terreno grande");
            }
            else if ( a < 100 && a >= 50)
            {
                Console.WriteLine("Terreno médio");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
    }
}
