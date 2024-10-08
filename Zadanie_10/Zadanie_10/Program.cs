using System;

namespace Zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Nullable<float> number = null;


            Console.Write(">>>Введите коэффициент масштабирования (целое число): ");
            int s = int.Parse(Console.ReadLine());


            Console.Write(">>>Введите смещение (целое число): ");
            int t = int.Parse(Console.ReadLine());


            _cScale(ref number, s, t);


            Console.WriteLine("<<<Результат: " + number);
        }

        static void _cScale(ref Nullable<float> n, int scale, int shift)
        {

            Random rand = new Random();

            n = (float)rand.NextDouble();

            //масштабирование числа (умножение на scale)
            n = n * scale;

            //добавление смещения shift
            n = n + shift;

        }

    }
}
