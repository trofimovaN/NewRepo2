using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static double Calculate(double a, double b)
        {
            return (Math.Exp(a) - Math.Exp(-a)) /
                   (Math.Exp(b) + Math.Exp(-b));
        }
        static void Main(string[] args)
        {
            double x = Calculate(2, 3)
                     + Calculate(5, 7)
                     + Calculate(4, 6);

            Console.WriteLine("x = {0:F3}", x);

            Console.ReadKey();
        }
    }
}
