using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Целочисленная_арифметика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            var number= int.Parse(Console.ReadLine());

            var a = number / 100;
            var b1= number / 10;
            var b = b1 % 10;
            var c= number % 10;

            var result = b * 100 + a * 10 + c;

            Console.WriteLine("Вот что получилось: " + result);


        }
    }
}
