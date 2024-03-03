using System;
namespace zadanie3
{
    class program
    {
        static void Main(string[] args)
        {
            double n, b, a, m = 0, z = 0, k;//инициализация переменных
            bool flg1, flg2, flg3;
            Console.WriteLine("Введите значение n");
            flg1 = double.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введите значение b");//ввод значений пользователем
            flg2 = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите значение a");
            flg3 = double.TryParse(Console.ReadLine(), out a);
            if (flg1 && flg2 && flg3)
            {
                if (b <= 4)
                {
                    m = Math.Pow(n, 2) * Math.Cos(n);
                }
                else
                {
                    m = Math.Pow(n, 2);
                }
                if (m == 9)
                {
                    k = Math.Pow(m, 2) + a;
                    z = Math.Sqrt(k);
                }
                if (m > 9)
                {
                    z = Math.Pow(a, 2) * Math.Cos(m);
                }
                if (m < 9)
                {
                    z = m + a;
                }
                Console.WriteLine($"Значение Z = {z}");
            }
            else
            {
                Console.WriteLine("Введенные данные некорректны");
            }
            Console.WriteLine("Для завершения работы нажмите любую клавишу");
            Console.ReadKey(true);
        }
    }
}

