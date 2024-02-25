using System;

namespace Zadanie6

{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x0, xk, dx, eps = 0.001;
            bool flg1, flg2, flg3, flg4, flg5;
            while (true)
            {
                Console.WriteLine(">>>Ввод констант<<<");
                Console.Write("~Введите значение a: ");
                flg1 = Double.TryParse(Console.ReadLine(), out a);
                Console.Write("~Введите значение b: ");
                flg2 = Double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(">>>Ввод значений диапозона<<<");
                Console.Write("~Введите начало диапазона: ");
                flg3 = Double.TryParse(Console.ReadLine(), out x0);
                Console.Write("~Введите конец диапозона: ");
                flg4 = Double.TryParse(Console.ReadLine(), out xk);
                Console.Write("~Введите шаг: ");
                flg5 = Double.TryParse(Console.ReadLine(), out dx);
                if (flg1 & flg2 & flg3 & flg4 & flg5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(">>>Error!!!<<<");
                    Console.WriteLine(">>>Данные введены некорректно! Повторите попытку!<<<");
                }
            }
            for (double x = x0; x <= xk; x += dx)
            {
                c = ((Math.Cos(Math.Abs(Math.Pow((Math.Pow(x, 2) + Math.Tan(x) + b), 3 / 2)))) + Math.Pow(double.Epsilon, b + a)) / Math.Tan(Math.Pow(x, 2) - b);
                Console.WriteLine($"При x = {x}, c = {c}");

                /*
                if (Math.Abs(Math.Tan(Math.Pow(x, 2) - b)) != 0)
                {
                    c = ((Math.Cos(Math.Abs(Math.Pow((Math.Pow(x, 2) + Math.Tan(x) + b), 1.5)))) + Math.Pow(double.Epsilon, b + a)) / Math.Tan(Math.Pow(x, 2) - b);
                    if (c <= eps)
                    {
                        c = 0;
                        Console.WriteLine($"При x = {x}, c = {c}");
                    }
                    /*
                    else
                    {
                        Console.WriteLine($"При x = {x}, c Не существует");
                    }
                    */
                    
                }
                else
                {
                    Console.WriteLine($"При x = {x}, c Не существует");
                }
                */
            }
            Console.WriteLine(">>>Рассчёт выполнен, для завершения работы нажмите любую клавишу<<<");
            Console.ReadKey(true);

        }
    }
}