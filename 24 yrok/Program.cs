using System;

/*
 *  null объеденения ??
 */

namespace _24_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "test";

            /*
            string result;

            if (str == null)
            {
                result = "Нет данных";
            }
            else
            {
                result = str;
            }

            Console.WriteLine(result);
            */

            Console.WriteLine(str ?? "Нет данных");



            // Решение одной из лаб
            string str1 = "Это нечто";

            string result = str1 ?? "";

            Console.WriteLine("Количество символов в строке " + str1.Length);
        }
    }
}
