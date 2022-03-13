using System;

/*
 *  Условный оператор switch
 */

namespace _10_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы ввели число 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели число 2");
                    break;
                default:
                    Console.WriteLine("Вы ввели число " + a + ".Я не знаю, что с этим делать");
                    break;
            }
            */


            string a = Console.ReadLine();

            switch (a)
            {
                case "+":
                    Console.WriteLine("Вы ввели плюс");
                    break;
                case "-":
                    Console.WriteLine("Вы ввели минус");
                    break;
                default:
                    Console.WriteLine("Вы ввели неизвестный символ");
                    break;


            }
        }
    }
}
