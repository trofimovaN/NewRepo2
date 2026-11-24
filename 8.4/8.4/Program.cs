using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество лет n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите годовую процентную ставку x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите сумму вклада m: ");
            double m = double.Parse(Console.ReadLine());

            double sum = m;

            int months = n * 12;

            for (int i = 1; i <= months; i++)
            {
                sum = sum + sum * x / 1200;

                Console.WriteLine("Месяц " + i + ": " + sum.ToString("F2") + " руб.");
            }   }
    }
}
