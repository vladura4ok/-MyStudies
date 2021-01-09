using System;

namespace Laba9
{
    enum stud
    {
        name,
        year,
        data
    }
    struct Student
    {
        public string name;
        public int year;
        public int group;
        public int resultF;
        public int resultX;
        public int resultM;
        public int midleRes;

        public void Write()
        {
            Console.WriteLine($"Фамилия инициалы: {name}\nГод рождения: {year}\nНомер группы: {group}" +
            $"\nОценки по физике: {resultF}\nОценки по химии: {resultX}\nОценки по математике: {resultM}" +
            $"\nСредний балл:{midleRes}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество студентов: ");
            int n = int.Parse(Console.ReadLine());

            Student[] stud = new Student[n];

            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student();
                Console.Write("Фамилия инициалы: ");
                stud[i].name = Console.ReadLine();
                Console.Write("Год рождения: ");
                stud[i].year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Номер группы: ");
                stud[i].group = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оценка по физике: ");
                stud[i].resultF = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оценка по химии: ");
                stud[i].resultX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оценка по математика: ");
                stud[i].resultM = Convert.ToInt32(Console.ReadLine());
                Console.Write("Средний балл: ");
                stud[i].midleRes = (stud[i].resultF + stud[i].resultX + stud[i].resultM) / 3;
                Console.WriteLine(stud[i].midleRes);

            }

            double obball = 0;

            for (int i = 0; i < stud.Length; i++)
            {
                obball += stud[i].midleRes;
                if (i + 1 == stud.Length)
                    obball /= i + 1;
            }
            Console.WriteLine("самый умный среди всех студентов: ", obball);

            for (int i = 0; i < stud.Length; i++)
            {
                if (obball < stud[i].midleRes)
                {
                    stud[i].Write(); break;
                }

            }
        }
    }
}