
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стихотворение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Сергей Есенин\r\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("'Шаганэ ты моя, Шаганэ...'\r\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Шаганэ ты моя, Шаганэ!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Потому, что я с севера, что ли,");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Я готов рассказать тебе поле,");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Про волнистую рожь при луне.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Шаганэ ты моя, Шаганэ!");
            Console.ResetColor();

            //Console.ReadKey();
        }
    }
}