using System;
using System.Linq;

/* 
 * Оператор условного null ?.
 */

namespace _26_yrok
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3 };
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементов массива" + (myArray?.Sum() ?? 0));
        }
    }
}
