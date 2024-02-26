using System;


namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, result1, result2, result;
            a = ((2.4 + 12.0 / 7.0) * 4.375) / (2.0 / 3.0 - 1.0 / 6.0);
            b = ((2.75 - 11.0 / 6.0) * 21.0) / (163.0 / 20.0 - 0.45);
            c = Math.Pow(Math.Abs(a), 1.0 / 3.0) - Math.Pow(Math.Abs(b), 1.0 / 2.0);
            f = c / (67.0 / 20.0);
            result1 = Math.Pow(Math.Abs(f), 1.0 / 5.0);
            d = Math.PI / Math.Pow(5, 1.0 / 3.0);
            e = 1.0 / (1.0 + d);
            result2 = Math.Pow(Math.Abs(e), 1.0 / 4.0);
            result = result1 + result2;
            Console.WriteLine($"Значение а={a}");
            Console.WriteLine($"Значение b={b}");
            Console.WriteLine($"Значение c={c}");
            Console.WriteLine($"Значение d={d}");
            Console.WriteLine($"Значение e={e}");
            Console.WriteLine($"Значение f={f}");
            Console.WriteLine($"Значение левой части выражения: {result1}");
            Console.WriteLine($"Значение правой части выражения: {result2}");
            Console.WriteLine($"Значение всего выражения: {result}");
            Console.WriteLine("Для завершения работы нажмите любую клавишу");
            Console.ReadKey(true);
        }
    }
}
