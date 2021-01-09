using System;

namespace laba3
{
    class Program
    {

        static void Max(int a, int b, int c)
        {
            if (a > b & a > c)
            {
                Console.WriteLine($"большее  {a}");
                

            }
            else if (b > a & b > c)
            {
                Console.WriteLine($"большее  {b}");

            }
            else if (c > a & c > b)
            {
                Console.WriteLine($"большее  {c}");

            }
            else
            {
                Console.WriteLine("что-то не так((");

            }

        }
        static void Data(int a_1, int b_1, int c_1)
        {
            if (b_1 == 1 || b_1 == 3 || b_1 == 5 || b_1 == 7 || b_1 == 8 || b_1 == 10 || b_1 == 12)
            {
                if (a_1 >= 1 & a_1 <= 31)
                {
                    Console.WriteLine($"{a_1} {b_1} {c_1}-yes");
                }
                else
                {
                    Console.WriteLine($"{a_1} {b_1} {c_1}-no");

                }
            }
            else if (b_1 == 4 || b_1 == 6 || b_1 == 9 || b_1 == 11)
            {
                if (a_1 >= 1 & a_1 <= 30)
                {
                    Console.WriteLine($"{a_1} {b_1} {c_1}-yes");
                }
                else
                {
                    Console.WriteLine($"{a_1} {b_1} {c_1}-no");

                }
            }
            else if (b_1 == 2)
            {
                if (a_1 >= 1 & a_1 <= 28)
                {
                    Console.WriteLine($"{a_1} {b_1} {c_1}-yes");
                }
                else
                {
                    Console.WriteLine($"{a_1} {b_1} {c_1}-no");

                }
            }
            else
            {
                Console.WriteLine($"{a_1} {b_1} {c_1}-no");

            }
        }

        static void Main(string[] args)
        {
            int a, b, c, a_1, b_1, c_1;

            Console.WriteLine("Введите а: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToInt32(Console.ReadLine());

            Max(a, b, c);



            Console.WriteLine("Ввеедите день : ");
            a_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввеедите месяц : ");
            b_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввеедите год : ");
            c_1 = Convert.ToInt32(Console.ReadLine());

            Data(a_1, b_1, c_1);


            for (int i = 1; 6>i; i++)
            {
                Console.WriteLine("хоть чтото помню блин ");
                if(i==4)
                {
                    Console.WriteLine("Это 4))) ");
                }
            }

        }
    }
}