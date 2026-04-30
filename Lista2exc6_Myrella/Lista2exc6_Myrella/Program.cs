using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc6_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double p;
            double h;

            Console.WriteLine("Indique seu peso: ");
            p = double.Parse(Console.ReadLine());

            Console.WriteLine("Indique sua altura: ");
            h = double.Parse(Console.ReadLine());

            a = p / (h * h);
           
            if (a < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (a >= 20 && a < 25)
            {
                Console.WriteLine("Peso ideial");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}
