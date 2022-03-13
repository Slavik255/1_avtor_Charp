using System;

/*
 * Тернарный оператор
 * 
 * [Первый операнд - условие] ? [Второй операнд - if_true] : [Третий операнд - if_false]
 */

namespace _15_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            string storedPassword = "abc";
            string enterPassword = Console.ReadLine();

            //if (enterPassword == storedPassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}

            accessAllowed = enterPassword == storedPassword ? true : false;

            Console.WriteLine(accessAllowed);

            Console.ReadLine();

            /*
            int inputData = int.Parse(Console.ReadLine());

            int outputData = (inputData < 0) ? 0 : inputData;

            Console.WriteLine(outputData);

            Console.ReadLine();
            */
        }
    }
}
