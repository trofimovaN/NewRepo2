using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());

            int min = 9;
            int position = 0;
            int number = 1;

            while (n > 0)
            {
                int digit = n % 10;

                if (digit < min)
                {
                    min = digit;
                    position = number;
                }

                n = n / 10;
                number++;
            }

            Console.WriteLine("Минимальная цифра = " + min);
            Console.WriteLine("Её порядковый номер справа налево = " + position);
        }
    }
}
