using System;

namespace Laba_10
{
    class Person
    {
        public string Age { get; set; }

        public string Name { get; set; }

        public Person(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public void Show()
        {
            Console.WriteLine($"Имя: {Name} \nВозрост: {Age}");
        }

    }

    class Student : Person
    {
        public string koleg { get; set; }
        public Student(string name, string age, string _koleg) : base(name, age)
        {
            koleg = _koleg;

        }
        public void Write()
        {
            Console.WriteLine($"Колледж: {koleg}");
        }

    }

    class SchoolBoy : Person
    {
        public string school { get; set; }

        public SchoolBoy(string name, string age, string _school) : base(name, age)
        {
            school = _school;

        }
        public void Show3()
        {
            Console.WriteLine($"Школа: {school}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student[] sMass = new Student[2];

            for (int i = 0; i < sMass.Length; i++)
            {
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите возрост: ");
                string age = Console.ReadLine();
                Console.WriteLine("Введите название колледжа: ");
                string koleg = Console.ReadLine();
                sMass[i] = new Student(name, age, koleg);
            }

            SchoolBoy[] schoolMass = new SchoolBoy[2];

            for (int i = 0; i < schoolMass.Length; i++)
            {
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите возрост: ");
                string age = Console.ReadLine();
                Console.WriteLine("Введите название школу: ");
                string school = Console.ReadLine();
                schoolMass[i] = new SchoolBoy(name, age, school);
            }
        }
    }
}