using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc10_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1;
            double P2;
            double m;

            Console.WriteLine("Digite a nota da P1:");
            P1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da P2:");
            P2 = double.Parse(Console.ReadLine());

            m = (P1 + 2 * P2) / 3;

            Console.WriteLine("Média: " + m);

            if (m >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
