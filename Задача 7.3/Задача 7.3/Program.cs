using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого короля");
            var whiteKingPosition = Console.ReadLine();

            int whiteH, whiteV;
            DecodePosition(whiteKingPosition, out whiteH, out whiteV);

            if (whiteH <1 || whiteH>8)
            {
                Console.WriteLine("Неверная позиция белого короля");
                return;
            }

            Console.WriteLine("Введите позицию черного коня");
            var blackKnightPosition = Console.ReadLine();

            int blackH, blackV;
            DecodePosition(blackKnightPosition, out blackH, out blackV);

            if (blackH < 1 || blackH > 8)
            {
                Console.WriteLine("Неверная позиция черного коня");
                return;
            }

            if (blackKnightPosition == whiteKingPosition)
            {
                Console.WriteLine("Фигуры не могут занимать одну клетку");
                return;
            }

            if (IsWhiteKingStrike(whiteKingPosition, blackKnightPosition) && IsBlackKnightStrike(blackKnightPosition, whiteKingPosition))
                Console.WriteLine("Фигуры находятся под боем друг друга");
            else if (IsWhiteKingStrike(whiteKingPosition, blackKnightPosition))
                Console.WriteLine("Конь находится под боем короля");
            else if (IsBlackKnightStrike(blackKnightPosition, whiteKingPosition))
                Console.WriteLine("Король находится под боем коня");
            
            else
                Console.WriteLine("Фигуры не находятся под боем друг друга");
        }

        static void DecodePosition(string position, out int horizontal, out int vertical)
        {
            horizontal = int.Parse(position.Substring(1));
            vertical = (int)position[0] - 0x60;
        }

        static bool IsWhiteKingStrike(string whiteKingPosition, string position)
        {
            int whiteH, whiteV;
            DecodePosition(whiteKingPosition, out whiteH, out whiteV);

            int pH, pV;
            DecodePosition(position, out pH, out pV);

            return (pH==whiteH-1 || pH==whiteH + 1 || pH==whiteH)&&(pV==whiteV-1 || pV==whiteV+1 || pV==whiteV);

        }

        static bool IsBlackKnightStrike(string blackKnightPosition, string position)
        {
            int blackH, blackV;
            DecodePosition(blackKnightPosition, out blackH, out blackV);

            int pH, pV;
            DecodePosition(position, out pH, out pV);

            return (Math.Abs(pH - blackH)==1 && Math.Abs(pV - blackV) == 2) || (Math.Abs(pH - blackH) == 2 && Math.Abs(pV - blackV) == 1);

        }
    }
}
