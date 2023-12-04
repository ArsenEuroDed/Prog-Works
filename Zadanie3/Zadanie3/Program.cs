using System;
namespace zadanie3
{
    class program
    {
        static void Main(string[] args)
        {
            double n, b, a, m, z;//инициализация переменных
            bool flg1, flg2, flg3;
            z = 0;
            m = 0;
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
                    z = Math.Pow(Math.Pow(m, 2) + a, 0.5);
                }
                if (m > 9)
                {
                    z = Math.Pow(a, 2) * Math.Cos(m);
                }
                else
                {
                    z = m + a;
                }
                Console.WriteLine(z);
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

