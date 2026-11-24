using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите площадь прямоугольника s: ");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Размеры прямоугольников:");

            for (int a = 1; a * a <= s; a++)
            {
                if (s % a == 0)
                {
                    int b = s / a;

                    Console.WriteLine(a + " x " + b);
                }
            }   }
    }
}
