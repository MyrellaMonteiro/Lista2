using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exc2_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Indique o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            if (a > b) { Console.WriteLine("O primeiro valor é maior"); }

            else if (b > a) { Console.WriteLine("O segundo valor é maior");  }

            else { Console.WriteLine("Os valores são iguais"); }
        }
    }
}
