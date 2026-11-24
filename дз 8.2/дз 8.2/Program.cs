using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Введите число: ");
                int k = int.Parse(Console.ReadLine());

                sum = sum + k * k;
            }

            Console.WriteLine("Сумма квадратов = " + sum);
        }
    }
}
