using System;

/*
 * Конструктор класса
 * 
 * Конструктор по умолчанию
 * 
 *  ctor
 */

namespace _41_yrok
{
    internal class Program
    {
        class Gun
        {
            public Gun(bool isLoaded)
            {
                // Обращаемся к той перемеенной которая является полем класса
                this.isLoaded = isLoaded;
            }
            private bool isLoaded;

            private void Reload()
            {
                Console.WriteLine("Заряжаю ...");
                isLoaded = true;
                Console.WriteLine("Заряжено!");
            }
            public void Shoot()
            {
                if (!isLoaded)
                {
                    Console.WriteLine("Орудие не заряжено!");
                    Reload();
                }
                Console.WriteLine("Пыщ - Пыщ\t");
                isLoaded = false;
            }
        }
        internal class Program1
        {
            static void Main(string[] args)
            {
                Gun gun = new Gun(false);
                gun.Shoot();
            }
        }
    }
}