using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_вычисление_заданных_величин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты центра квадарата, сначала X, затем Y");
            double centreCoordsX = double.Parse(Console.ReadLine());
            double centreCoordsY = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты вершины квадарата, сначала X, затем Y");
            double topCoordsX = double.Parse(Console.ReadLine());
            double topCoordsY = double.Parse(Console.ReadLine());

            double dlinaPoX = Math.Abs(centreCoordsX - topCoordsX);
            double dlinaPoY = Math.Abs(centreCoordsY - topCoordsY);

            double polDiagonaliVkv = dlinaPoX * dlinaPoX + dlinaPoY * dlinaPoY;
            double diagonalVkv = 4 * polDiagonaliVkv;

            double storonaKvadrataVkv = diagonalVkv/2;
            double storonaKvadrata = Math.Sqrt(storonaKvadrataVkv);

            double perimeter = 4 * storonaKvadrata;
            double area = storonaKvadrataVkv;

            Console.WriteLine("Площадь квадрата " + area);
            Console.WriteLine("Периметр квадрата " + perimeter);


            
        }
    }
}