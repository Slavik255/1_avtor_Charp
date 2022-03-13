using System;

/*
 *  Конструкция if else
 */

/*
 *                      if(утверждение или выражение)
 *                      {
 *                          действие 1;
 *                      }
 *                      else
 *                      {
 *                          действие 2;
 *                      } 
 */

namespace _8_yrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool isInfected = false;

              if (isInfected)
              {
                  Console.WriteLine("Персонаж инфицирован");
              }
              else
              {
                  Console.WriteLine("Персонаж здоров!");
              }*/

            int a;

            a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("a равно 5");
            }
            else
            {
                Console.WriteLine("a  не равно 5");
            }

        }
    }
}
