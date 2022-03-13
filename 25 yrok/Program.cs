using System;

/*
 * Оператор присваивания объеденения  со значением NULL ??=
 * 
 *  Решение с проблемой в этом видео https://www.youtube.com/watch?v=Jb-dFOXrSa0
 */

namespace _25_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "test";

            //string result = str ?? "defaut string";
            //Console.WriteLine("Количество символов в строчке" + result.Length);

            str ??= string.Empty;

            Console.WriteLine("Количество символов в строчке " + str.Length);
        }
    }
}
