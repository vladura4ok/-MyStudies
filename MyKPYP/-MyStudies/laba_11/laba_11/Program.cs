using System;

namespace Laba11Interfece
{
    class Program
    {
        interface ITest
        {
            int NumTest { get; }
            void ReadNumTest();
        }

        interface IExem
        {
            void ReadBallExem();
        }

        interface IGrandExem
        {
            void GrandExem();
        }

        interface IChallenge
        {
            void Challenge();
        }
        interface IStudent
        {
            string Name { get; set; }
        }
        class Person : ITest, IStudent, IExem, IGrandExem, IChallenge
        {
            int _num;
            int _exem;
            int _gexem;
            int _chall;
            public string Name { get; set; }
            public Person(string name, int num, int exem, int gexem, int chall)
            {
                Name = name;
                _num = num;
                _exem = exem;
                _gexem = gexem;
                _chall = chall;

            }

            public int NumTest { get { return _num; } }
            public void ReadNumTest()
            {
                Console.Write("Номер теста: " + _num);

            }

            public void ReadBallExem()
            {
                Console.Write("\nНомер экз билета: " + _exem);

            }

            public void GrandExem()
            {
                Console.WriteLine("\nНомер билета выпускного экзамена: " + _gexem);
            }

            public void Challenge()
            {
                Console.WriteLine("Номер испытания: " + _chall);
            }
        }




        static void Main(string[] args)
        {

            Console.WriteLine("Номер теста: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер экз билета: ");
            int exem = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер билета выпускного экзамена: ");
            int gexem = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер испытания: ");
            int chall = int.Parse(Console.ReadLine());
            Person pers = new Person("AVE ROME", number, exem, gexem, chall);
            pers.ReadNumTest();
            pers.ReadBallExem();
            pers.GrandExem();
            pers.Challenge();

        }

    }
}