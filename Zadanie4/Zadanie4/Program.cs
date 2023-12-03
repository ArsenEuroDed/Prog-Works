
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace zadanie4
{
    class Program
    {
        public static void Main(string[] args)
        {
            char pervS, vtoroiS, tmpS;
            bool flg1, flg2;
            Console.Write("Введите первый символ:");
            flg1 = char.TryParse(Console.ReadLine(), out pervS);
            Console.Write("Введите второй символ:");
            flg2 = char.TryParse(Console.ReadLine(), out vtoroiS);
            if (flg1 && flg2)
            {
                if ((int)pervS > (int)vtoroiS)
                {
                    tmpS = pervS;
                    pervS = vtoroiS;
                    vtoroiS = tmpS;
                    Console.WriteLine("Символы заменены местами ");
                    Console.Write("Первый символ ");
                    Console.Write(pervS);
                    Console.Write(" Второй символ ");
                    Console.Write(vtoroiS);
                }
                else
                {
                    Console.WriteLine("Символы на своих местах");
                }
            }
            else
            {
                Console.WriteLine("Введенные символы некорректны");
            }
            Console.WriteLine(" Для завершения программмы нажмите любую клавишу");
            Console.ReadKey(true);
        }
    }
}
