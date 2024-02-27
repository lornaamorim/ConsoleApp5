using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String a, b, c;

            Console.WriteLine("Informe o valor de A: ");
            a = Console.ReadLine();

            Console.WriteLine("Informe o valor de B: ");
            b = Console.ReadLine();

            c = a;
            a = b;
            b = c;

            Console.WriteLine("O novo valor de A é: " + a);
            Console.WriteLine("O novo valor de B é: " + b);

            Console.ReadKey();  

        }
    }
}
