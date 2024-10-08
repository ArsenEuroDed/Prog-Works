using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            double xAcos, xAbs, xAsin, xAtan, xAtan21, xAtan22, xCeiling, xCos, xCosh, xEquals1, xEquals2, xExp, xFloor, xLog, xLog10, xMax1, xMax2, xPow1, xPow2, xRound, xSign, xSin, xSinh, xSqrt, xTan, xTanh, xTruncate, xMin1, xMin2;
            int xDivRem1, xDivRem2, xDivRemResult, xBigMul1, xBigMul2;
            //Объявление необходимых переменных
            Console.WriteLine("$$$___Нажмите любую клавишу, чтобы ввести исходные данные функций___$$$");
            Console.ReadKey(true);

            Console.WriteLine(">>>Введите данные для расчета Abs: ");
            double.TryParse(Console.ReadLine(), out xAbs);

            Console.WriteLine(">>>Введите данные для расчета Acos: ");
            double.TryParse(Console.ReadLine(), out xAcos);

            Console.WriteLine(">>>Введите данные для расчета Asin: ");
            double.TryParse(Console.ReadLine(), out xAsin);

            Console.WriteLine(">>>Введите данные для расчета Atan: ");
            double.TryParse(Console.ReadLine(), out xAtan);

            Console.WriteLine(">>>Введите первую переменную для расчета Atan2: ");
            double.TryParse(Console.ReadLine(), out xAtan21);
            Console.WriteLine(">>>Введите вторую переменную для расчета Atan2: ");
            double.TryParse(Console.ReadLine(), out xAtan22);

            Console.WriteLine(">>>Введите первую переменную для расчета BigMul: ");
            int.TryParse(Console.ReadLine(), out xBigMul1);
            Console.WriteLine(">>>Введите вторую переменную для расчета BigMul: ");
            int.TryParse(Console.ReadLine(), out xBigMul2);

            Console.WriteLine(">>>Введите данные для расчета Ceiling: ");
            double.TryParse(Console.ReadLine(), out xCeiling);

            Console.WriteLine(">>>Введите данные для расчета Cos: ");
            double.TryParse(Console.ReadLine(), out xCos);

            Console.WriteLine(">>>Введите данные для расчета Cosh: ");
            double.TryParse(Console.ReadLine(), out xCosh);

            Console.WriteLine(">>>Введите первую переменную для расчета DivRem: ");
            int.TryParse(Console.ReadLine(), out xDivRem1);
            Console.WriteLine(">>>Введите вторую переменную для расчета DivRem: ");
            int.TryParse(Console.ReadLine(), out xDivRem2);

            Console.WriteLine(">>>Введите первую переменную для расчета Equals: ");
            double.TryParse(Console.ReadLine(), out xEquals1);
            Console.WriteLine(">>>Введите вторую переменную для расчета Equals: ");
            double.TryParse(Console.ReadLine(), out xEquals2);

            Console.WriteLine(">>>Введите данные для расчета Exp: ");
            double.TryParse(Console.ReadLine(), out xExp);

            Console.WriteLine(">>>Введите данные для расчета Floor: ");
            double.TryParse(Console.ReadLine(), out xFloor);

            Console.WriteLine(">>>Введите данные для расчета Log: ");
            double.TryParse(Console.ReadLine(), out xLog);

            Console.WriteLine(">>>Введите данные для расчета Log10: ");
            double.TryParse(Console.ReadLine(), out xLog10);

            Console.WriteLine(">>>Введите первую переменную для расчета Max: ");
            double.TryParse(Console.ReadLine(), out xMax1);
            Console.WriteLine(">>>Введите вторую переменную для расчета Max: ");
            double.TryParse(Console.ReadLine(), out xMax2);

            Console.WriteLine(">>>Введите первую переменную для расчета Min: ");
            double.TryParse(Console.ReadLine(), out xMin1);
            Console.WriteLine(">>>Введите вторую переменную для расчета Min: ");
            double.TryParse(Console.ReadLine(), out xMin2);

            Console.WriteLine(">>>Введите первую переменную для расчета Pow: ");
            double.TryParse(Console.ReadLine(), out xPow1);
            Console.WriteLine(">>>Введите вторую переменную для расчета Pow: ");
            double.TryParse(Console.ReadLine(), out xPow2);

            Console.WriteLine(">>>Введите данные для расчета Round: ");
            double.TryParse(Console.ReadLine(), out xRound);

            Console.WriteLine(">>>Введите данные для расчета Sign: ");
            double.TryParse(Console.ReadLine(), out xSign);

            Console.WriteLine(">>>Введите данные для расчета Sin: ");
            double.TryParse(Console.ReadLine(), out xSin);

            Console.WriteLine(">>>Введите данные для расчета Sinh: ");
            double.TryParse(Console.ReadLine(), out xSinh);

            Console.WriteLine(">>>Введите данные для расчета Sqrt: ");
            double.TryParse(Console.ReadLine(), out xSqrt);

            Console.WriteLine(">>>Введите данные для расчета Tan: ");
            double.TryParse(Console.ReadLine(), out xTan);

            Console.WriteLine(">>>Введите данные для расчета Tanh: ");
            double.TryParse(Console.ReadLine(), out xTanh);

            Console.WriteLine(">>>Введите данные для расчета Truncate: ");
            double.TryParse(Console.ReadLine(), out xTruncate);

            Console.WriteLine("#################################################################################################");

            //выводим данные общей части
            Console.WriteLine("$$$___Нажмите любую клавишу, чтобы увидеть значения полученные в результате работы функций____$$$");
            Console.WriteLine(">>>Значение Abs: " + Math.Abs(xAbs));
            Console.WriteLine(">>>Константа E = " + Math.E);
            Console.WriteLine(">>>Константа PI = " + Math.PI);
            Console.WriteLine(">>>Значение Acos: " + Math.Acos((xAcos * Math.PI) / 180));
            Console.WriteLine(">>>Значение Asin: " + Math.Asin((xAsin * Math.PI) / 180));
            Console.WriteLine(">>>Значение Atan: " + Math.Atan((xAtan * Math.PI) / 180));
            Console.WriteLine(">>>Значение Atan2: " + Math.Atan2(((xAtan21 * Math.PI) / 180), ((xAtan22 * Math.PI) / 180)));
            Console.WriteLine(">>>Значение BigMul: " + Math.BigMul(xBigMul1, xBigMul2));
            Console.WriteLine(">>>Значение Ceiling: " + Math.Ceiling(xCeiling));
            Console.WriteLine(">>>Значение Cos: " + Math.Cos((xCos * Math.PI) / 180));
            Console.WriteLine(">>>Значение Cosh: " + Math.Cosh((xCosh * Math.PI) / 180));
            Console.WriteLine(">>>Значение DivRem: " + Math.DivRem(xDivRem1, xDivRem2, out xDivRemResult));
            Console.WriteLine(">>>Значение Equals: " + Math.Equals(xEquals1, xEquals2));
            Console.WriteLine(">>> Exp: " + Math.Exp(xExp));
            Console.WriteLine(">>> Floor: " + Math.Floor(xFloor));
            Console.WriteLine(">>> Log: " + Math.Log(xLog));
            Console.WriteLine(">>> Log10: " + Math.Log10(xLog10));
            Console.WriteLine(">>> Max: " + Math.Max(xMax1, xMax2));
            Console.WriteLine(">>> Min: " + Math.Min(xMin1, xMin2));
            Console.WriteLine(">>> Pow: " + Math.Pow(xPow1, xPow2));
            Console.WriteLine(">>> Round: " + Math.Round(xRound));
            Console.WriteLine(">>> Sign: " + Math.Sign(xSign));
            Console.WriteLine(">>> Sin: " + Math.Sin((xSin * Math.PI) / 180));
            Console.WriteLine(">>> Sinh: " + Math.Sinh((xSinh * Math.PI) / 180));
            Console.WriteLine(">>> Sqrt: " + Math.Sqrt(xSqrt));
            Console.WriteLine(">>> Tan: " + Math.Tan((xTan * Math.PI) / 180));
            Console.WriteLine(">>> Tanh: " + Math.Tanh((xTanh * Math.PI) / 180));
            Console.WriteLine(">>> Truncate: " + Math.Truncate(xTruncate));
            Console.WriteLine("########################################################");
            Console.WriteLine("Нажмите любую клавишу, чтобы завершить работу программы.");
            Console.ReadKey();
        }
    }
}