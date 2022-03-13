using System;

/*           
 *           Логические операторы
 *           
 *           &&  Сокращенное И
 *           ||  Сокращенное ИИ
 *           &   И
 *           |   ИЛИ
 *           !   НЕ (унарный)
 */

namespace _9_yrok
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

            bool isHighTemrature = true;

            bool hasNoCooling = true;

            if (isHighTemrature && hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процессора!");
            }
        }
    }
}
