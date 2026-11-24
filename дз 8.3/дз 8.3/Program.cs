using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int current = 0;
                int max = 0;

                Console.WriteLine("Введите последовательность чисел. Для окончания введите 0.");

                double a = double.Parse(Console.ReadLine());

                while (a != 0)
                {
                    if (a > 0)
                    {
                        current++;

                        if (current > max)
                        {
                            max = current;
                        }
                    }
                    else
                    {
                        current = 0;
                    }

                    a = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Наибольшее количество положительных чисел подряд: " + max);
            }  }
    }
}
