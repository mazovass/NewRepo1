using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строки._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var word = "пирамида";

            var result1 = word.Substring(6, 1) + word.Substring(1, 1) + word.Substring(4, 1) + word.Substring(3, 1);
            var result2 = word.Substring(1, 3) + word.Remove(0, 5);

            Console.WriteLine($"В начале было слово \"{word}\". ");
            Console.WriteLine($"Мы получили имена \"{result1}\" и \"{result2}\".");

        }
    }
}
