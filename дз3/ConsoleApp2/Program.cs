using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static double Calculate(double x)
        {
            double y = Math.Sin((3.2 + Math.Sqrt(x + 1)) / Math.Abs(5 * x));
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            if (x < -1 || x == 0)
            {
                Console.WriteLine("Недопустимое значение x");
            }
            else
            {
                double y = Calculate(x);
                Console.WriteLine("y = " + y);
            }

            Console.ReadKey();

        }
    }
}
