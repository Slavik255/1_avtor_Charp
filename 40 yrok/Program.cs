using System;

// Инкапсуляция 
// Нужна для последовательности, то есть оружие не может сразу стрелять
// Без привата ломается логика

namespace _40_yrok
{
    class Gun
    {
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }
}
