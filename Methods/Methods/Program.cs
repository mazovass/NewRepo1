using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            var x = double.Parse(Console.ReadLine());
            var y = Calculate(x);

            Console.WriteLine("f(x)=" + y);
        }

        static double Calculate(double x) => (Math.Abs(x + 1) - Math.Abs(x - 1)) / Math.Abs(x);
    }
}
