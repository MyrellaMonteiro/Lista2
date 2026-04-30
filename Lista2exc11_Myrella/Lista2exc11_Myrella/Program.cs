using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc11_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1;
            double P2;

            Console.WriteLine("Digite a nota da P1:");
            P1 = double.Parse(Console.ReadLine());

            P2 = (15 - P1) / 2;

            Console.WriteLine("Você precisa tirar: " + P2 + " na P2 para ser aprovado");

            if (P2 > 10)
            {
                Console.WriteLine("Situação: impossível atingir a média");
            }
            else if (P2 <= 0)
            {
                Console.WriteLine("Situação: já está aprovado");
            }
        }
    }
}
