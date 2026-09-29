using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace арифметика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону ромба");
            double side = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите угол между сторонами ромба в градусах");
            double angleInDegrees = double.Parse(Console.ReadLine());

            double angleInRadians = angleInDegrees * Math.PI / 180;

            double area = side * side * Math.Sin(angleInRadians);

            double perimeter = 4 * side;

            Console.WriteLine("Площадь ромба " + area);
            Console.WriteLine("Периметр ромба " + perimeter);
        }
    }
}
