using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы___8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = 6350;

            Console.WriteLine("Высота (км)    Расстояние до горизонта (км)");

            for (int h = 1; h <= 10; h++)
            {
                double d = Math.Sqrt((R + h) * (R + h) - R * R);

                Console.WriteLine(h + "              " + d.ToString("F2"));
            }   }
    }
}
