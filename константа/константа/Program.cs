using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace константа
{
    internal class Program
    {
        private static double V;

        static void Main(string[] args)
        {
            const double Phi = (1 + Math.Sqrt(5)) / V;

            int number = 2;

            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(number++ + ++number);
            Console.WriteLine(number);

            number += 3;
            Console.WriteLine(number);

            Console.WriteLine(Phi - (1 + 1 / Phi));

        }
    }
}
