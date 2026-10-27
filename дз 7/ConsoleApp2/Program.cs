using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static bool CheckNumber(int n)
        {
            return n % 2 != 0 && n % 3 != 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckNumber(n));
        }
    }
}
