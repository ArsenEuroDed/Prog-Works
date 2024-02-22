using System;
class Program
{
    public static void Main(string[] args)
    {
        char cirill;
        Console.WriteLine("Введите кириллический символ");
        char.TryParse(Console.ReadLine(), out cirill);
        switch (cirill)
        {
            case 'А':
            case 'а':
                Console.WriteLine("Этот символ в транслите: A");
                break;

            case 'Б':
            case 'б':
                Console.WriteLine("Этот символ в транслите: B");
                break;


            case 'В':
            case 'в':
                Console.WriteLine("Этот символ в транслите: V");
                break;

            case 'Г':
            case 'г':
                Console.WriteLine("Этот символ в транслите: G");
                break;

            case 'Д':
            case 'д':
                Console.WriteLine("Этот символ в транслите: D");
                break;

            case 'Е':
            case 'е':
                Console.WriteLine("Этот символ в транслите: YE");
                break;

            case 'Ё':
            case 'ё':
                Console.WriteLine("Этот символ в транслите: YE");
                break;

            case 'Ж':
            case 'ж':
                Console.WriteLine("Этот символ в транслите: ZH");
                break;

            case 'З':
            case 'з':
                Console.WriteLine("Этот символ в транслите: Z");
                break;

            case 'И':
            case 'и':
                Console.WriteLine("Этот символ в транслите: I");
                break;

            case 'Й':
            case 'й':
                Console.WriteLine("Этот символ в транслите: Y");
                break;

            case 'К':
            case 'к':
                Console.WriteLine("Этот символ в транслите: K");
                break;

            case 'Л':
            case 'л':
                Console.WriteLine("Этот символ в транслите: L");
                break;

            case 'М':
            case 'м':
                Console.WriteLine("Этот символ в транслите: M");
                break;

            case 'Н':
            case 'н':
                Console.WriteLine("Этот символ в транслите: N");
                break;

            case 'О':
            case 'о':
                Console.WriteLine("Этот символ в транслите: O");
                break;

            case 'П':
            case 'п':
                Console.WriteLine("Этот символ в транслите: P");
                break;

            case 'Р':
            case 'р':
                Console.WriteLine("Этот символ в транслите: R");
                break;

            case 'С':
            case 'с':
                Console.WriteLine("Этот символ в транслите: S");
                break;

            case 'Т':
            case 'т':
                Console.WriteLine("Этот символ в транслите: T");
                break;

            case 'У':
            case 'у':
                Console.WriteLine("Этот символ в транслите: U");
                break;

            case 'Ф':
            case 'ф':
                Console.WriteLine("Этот символ в транслите: F");
                break;

            case 'Х':
            case 'х':
                Console.WriteLine("Этот символ в транслите: KH");
                break;

            case 'Ц':
            case 'ц':
                Console.WriteLine("Этот символ в транслите: TS");
                break;

            case 'Ч':
            case 'ч':
                Console.WriteLine("Этот символ в транслите: CH");
                break;

            case 'Ш':
            case 'ш':
                Console.WriteLine("Этот символ в транслите: SH");
                break;

            case 'Щ':
            case 'щ':
                Console.WriteLine("Этот символ в транслите: SHCH");
                break;

            case 'Ы':
            case 'ы':
                Console.WriteLine("Этот символ в транслите: Y");
                break;

            case 'Э':
            case 'э':
                Console.WriteLine("Этот символ в транслите: E");
                break;

            case 'Ю':
            case 'ю':
                Console.WriteLine("Этот символ в транслите: IU");
                break;

            case 'Я':
            case 'я':
                Console.WriteLine("Этот символ в транслите: IA");
                break;

            default:
                Console.WriteLine("Введеный символ не коректен, либо он не поддается транслитерации");
                break;
        }
        Console.WriteLine("Нажмите любую клавишу для завершения работы программы");
        Console.ReadKey(true);
    }
}