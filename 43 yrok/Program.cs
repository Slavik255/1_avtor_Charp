using System;

/*
 * this
 */

namespace _43_yrok
{
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {

            this.lastName = lastName;
            _birthday = birthday;
        }
        public Student(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName, birthday)
        {
            _firstName = firstName;
            _middleName = middleName;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        private string lastName;
        private string _firstName;
        private string _middleName;
        private DateTime _birthday;

        public void Print()
        {
            Console.WriteLine($"Имя: {_firstName}\tФамилия: {lastName}\tОтчество: {_middleName}\nДата рождения {_birthday}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Мищук", new DateTime(2004, 04, 15));
            student1.Print();
        }
    }
}
