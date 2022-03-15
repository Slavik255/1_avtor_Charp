using System;

/*
 * ООП
 * Класс
 * Объект класса
 * Как в отдельный файл вынести класс https://www.youtube.com/watch?v=lg_D_1KNBek
 * Методы класса
 */

namespace _38_yrok
{
    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue

    }
    class Tochka
    {
        public int x;
        public int y;
        public Color color;


    }
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;
    }
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Мищук";
            student.middleName = "Вячеслав";
            student.lastName = "Витальевич";
            student.age = 17;
            student.id = Guid.NewGuid();
            student.group = "ИВТ-3";

            return student;
        }
        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте: ");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Возвраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);

            /*
            Tochka tochka = new Tochka();
            tochka.x = 4;
            tochka.y = 2;
            tochka.color = Color.Red;
            //Console.WriteLine($"X: {tochka.x} | Y: {tochka.y} | Color: {tochka.color}");

            Tochka tochka1 = new Tochka();
            tochka1.x = 2;
            tochka1.y = 6;
            tochka1.color = Color.Green;
            //Console.WriteLine($"X: {tochka1.x} | Y: {tochka1.y} | Color: {tochka1.color}");
            */
        }
    }
}
