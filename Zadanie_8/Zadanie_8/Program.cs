using System;

class Program
{
    static void Main(string[] args)
    {
        //переменные для поиска индекса
        int maxIndex = 0;
        int minIndex = 0;

        //переменная для определения размерности массива
        int size = 0;

        // Запрашиваем размер массива у пользователя
        Console.Write(">>>Введите размер массива: ");
        
        // Проверяем, корректно ли введён размер
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.Write(">>>Неверное значение, пожалуйста повторите ввод: ");
        }

        // Инициализация массива
        int[] array = new int[size];

        // Ввод элементов массива
        Console.WriteLine($">>>Введите {size} элементов массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i}: ");
            while (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.Write($">>>Пожалуйста, введите целое числовое значение для элемента {i}: ");
            }
        }

        // Поиск индексов наибольшего и наименьшего элементов

        for (int i = 1; i < size; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }

        // Вычисление разности индексов
        int indexDifference = maxIndex - minIndex;

        // Вывод результата
        Console.WriteLine($">>>Разность индексов наибольшего и наименьшего элементов массива: {indexDifference}");
        Console.WriteLine(">>>Для завершения работы программы нажмите любую клавишу<<<");
        Console.ReadKey(true);
        Console.ReadKey(true);
    }
}