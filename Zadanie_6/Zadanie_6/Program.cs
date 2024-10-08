using System;

class Program
{
    static void Main()
    //основная часть программы
    {
        //объявляем еременные для исходных данных
        double alpha, beta, x0, xk, dx;

        //ввод данных с контролем ввода
        //для ввода используем отдельный метод, где выполняются проверки ввода
        alpha = GetValidatedInput("Введите значение alpha (действительное число): ");
        beta = GetValidatedInput("Введите значение beta (действительное число): ");
        x0 = GetValidatedInput("Введите значение x0 (начальное значение, действительное число): ");
        xk = GetValidatedInput("Введите значение xk (конечное значение, действительное число): ");
        dx = GetValidatedInput("Введите значение deltaX (шаг, положительное действительное число): ", positive: true);

        //цикл по значениям x от x0 до xk с шагом delta-x
        for (double x = x0; x <= xk; x = x + dx)
        {
            //проверяем ограничения для тангенса в знаменателе
            double znamenatelArgument = x * x - beta;
            if (Math.Abs(znamenatelArgument % Math.PI - Math.PI / 2) < 1e-6)
            {
                Console.WriteLine($"Для x = {x} знаменатель стремится к бесконечности (тангенс в точке асимптоты). Пропускаем это значение.");
                continue;
            }

            //вычисляем числитель и знаменатель
            double chislitel = Math.Cos(Math.Pow(x * x + Math.Tan(x) + beta, 1.0 / 3.0)) + Math.Exp(beta + alpha);
            double znamenatel = Math.Tan(znamenatelArgument);

            //проверка на деление на ноль (на случай непредвиденных ситуаций)
            if (znamenatel == 0)
            {
                Console.WriteLine($"Для x = {x} знаменатель равен нулю. Пропускаем это значение.");
                continue; //если знаменатель дроби равен нулю, то пропускаем текущее значение x
            }

            //вычисляем значение c
            double c = chislitel / znamenatel;

            //вывод результата на экран
            //используем форматированный вывод (4 и 6 знаков после запятой)
            Console.WriteLine($"При x = {x:F4}, значение c = {c:F6}");

        }
    }

    //метод для проверки корректного ввода данных
    static double GetValidatedInput(string prompt, bool positive = false)
    {
        double value;
        bool valid = false;

        //цикл для повторного запроса данных до получения корректного значения
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            //проверяем, корректен ли ввод
            if (double.TryParse(input, out value))
            {
                //если значение должно быть положительным, проверяем это условие
                if (positive && value <= 0)
                {
                    Console.WriteLine("Значение должно быть положительным. Попробуйте снова.");
                }
                else
                {
                    valid = true;  //ввод корректный
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите действительное число.");
            }

        } while (!valid);

        return value;  //возвращаем введенное значение
    }

}
