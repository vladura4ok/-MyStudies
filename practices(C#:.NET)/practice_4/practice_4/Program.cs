using System;

namespace practice_4
{
    class Program
    {
        class MyArr
        {

            public int[] a;


            public MyArr(int[] a)
            {

                this.a = a;
            }
            public MyArr()
            {

                a = new int[5];
            }

            public static MyArr operator -(MyArr obj1, int n)
            {
                MyArr arr = new MyArr();

                for (int i = 0; i < 4; i++)
                {

                    if (i >= n)
                    {
                        arr.a[i] = obj1.a[i + 1];
                    }
                    else
                    {
                        arr.a[i] = obj1.a[i];
                    }

                }

                return arr;

            }



            static double vector(double a_1, double a_2, double b_1, double b_2)
            {
                double a = (a_1 * b_1 + a_2 * b_2) / (Math.Sqrt(Math.Pow(a_1, 2) + Math.Pow(a_2, 2)) * Math.Sqrt(Math.Pow(b_1, 2) + Math.Pow(b_2, 2)));
                double v = Math.Acos(a);
                Console.WriteLine(v);
                return v;

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите вектор А");
                Console.Write("Введите x: ");
                double a_1 = double.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                double a_2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вектор B");
                Console.Write("Введите x: ");
                double b_1 = double.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                double b_2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вектор C");
                Console.Write("Введите x: ");
                double c_1 = double.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                double c_2 = double.Parse(Console.ReadLine());
                double vector_1 = vector(a_1, a_2, b_1, b_2);
                double vector_2 = vector(a_1, a_2, c_1, c_2);
                double vector_3 = vector(c_1, c_2, b_1, b_2);
                if (vector_1 > vector_2 && vector_1 == vector_3)
                {
                    Console.WriteLine("наименьший А и B");

                }
                else if (vector_2 < vector_1 && vector_2 < vector_3)
                {
                    Console.WriteLine("наименьший А и C");

                }
                else if (vector_3 < vector_2 && vector_3 < vector_1)
                {
                    Console.WriteLine("наименьший C и B");

                }
                else
                {
                    Console.WriteLine("==");
                }
                int[] a = new int[5];
                Random rnd = new Random();

                for (int i = 0; i < 5; i++)
                {
                    a[i] = rnd.Next(1, 10);
                }

                Console.Write("Массив A: ");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
                Console.Write("s: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (n>-1 && n<5)
                {
                    MyArr Point1 = new MyArr(a);
                    MyArr Point3 = Point1 - n;
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(Point3.a[i] + " ");
                    }
                }
            }

        }

    }
}
