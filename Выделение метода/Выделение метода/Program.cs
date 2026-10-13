using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Выделение_метода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate();

            Console.WriteLine(Math.Round(x,3));

        }

        static double Calculate() => F(0, F(1, F(2, F(3, 4))));

        static double F(double x, double y) => x + Math.Sin(y);
    }
}
