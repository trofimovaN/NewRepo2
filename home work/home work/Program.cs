using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Александр Сергеевич Пушкин");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Унылая пора! Очей очарованье!");
            Console.WriteLine() ;

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Унылая пора! Очей очарованье!\r\nПриятна мне твоя прощальная краса —\r\nЛюблю я пышное природы увяданье,\r\nВ багрец и в золото одетые леса,\r\nВ их сенях ветра шум и свежее дыханье,\r\nИ мглой волнистою покрыты небеса,\r\nИ редкий солнца луч, и первые морозы,\r\nИ отдаленные седой зимы угрозы.");
        }
    }
}
