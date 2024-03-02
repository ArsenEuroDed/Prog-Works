using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 0, n;
            bool flg;
            Console.WriteLine(">>>Введите значение n<<<");
            while (true)
            {
                flg = double.TryParse(Console.ReadLine(), out n);
                if (flg && n>1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(">>>Ошибка!Введено некорректное значение n, повторите попытку<<<");
                }
            }
            for (double i = 1; i <= n; i++)
            {
                double f = 1;
                for (double k = i; k > 0; k--)
                {
                    f *= k;
                }
                c += 1 / f;
            }
            Console.WriteLine($"Значение c = {c}");
            Console.WriteLine(">>>Для завершения работы программы нажмите любую клавишу<<<");
            Console.ReadKey(true);
        }
    }
}
