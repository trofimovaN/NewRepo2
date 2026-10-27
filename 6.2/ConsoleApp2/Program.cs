using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = "гардероб";

            var result1 = word.Substring(3, 1) + word.Substring(2, 1) + word.Substring(1, 1) + word.Substring(0, 1) + word.Substring(1, 1);
            var result2 = word.Substring(7, 1) + word.Substring(4, 1) + word.Substring(3, 1) + word.Substring(5, 1) + word.Substring(6, 1);

            Console.WriteLine($"В начале было слово \"{word}\".");
            Console.WriteLine($"Мы получили слова \"{result1}\" и \"{result2}\".");
        }
    }
}
