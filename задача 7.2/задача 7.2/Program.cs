using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = InputCoordinate("x");
            var y = InputCoordinate("y");

            Console.WriteLine($"Точка ({x}; {y}) лежит в области: {IsInArea(x, y)} ");
        }

        static double InputCoordinate(string coordinateName)
        {
            Console.WriteLine($"Введите координату {coordinateName}");
            return double.Parse(Console.ReadLine());
        }

        static bool IsInArea(double x, double y) =>
            y >= -0.5 && y <= 2 && x >= -1 && x <= 1.5 ;
    }
}
