using System;

/*
 * Трехмерные массивы
 */

namespace _22_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[4, 3, 5];

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(10);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page №: " + i + 1);

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
