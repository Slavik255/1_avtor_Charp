using System;

/*
 * Заполнение двумерного массива случайными числами с#
 * 
 * Заполнение двумерного массива с клавиатуры с#
 */

namespace _20_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];

            // Random random = new Random();

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //myArray[i, j] = random.Next(100);
                    Console.WriteLine("Y: " + i + " X: " + j);
                    myArray[i, j] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
