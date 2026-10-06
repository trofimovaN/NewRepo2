using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace арифметика_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int n = int.Parse(Console.ReadLine());

            int a = n / 1000;
            int b = n / 100 % 10;
            int c = n / 10 % 10;
            int d = n % 10;

            int result = a * 1000 + c * 100 + b * 10 + d;

            Console.WriteLine("Полученное число: " + result);
        }
    }
}
