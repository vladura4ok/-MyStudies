using System;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0, u, j = 2, n;
            double e, x, z, numeral_sin, y, v = 0, k = 0;
            Console.WriteLine("задание 1.1");
            Console.WriteLine("ВВедите а:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 10 && a <= 99)
            {
                b = 1;
            }
            while (b == 0)
            {
                Console.WriteLine("Неверное значение попробуйте ещё раз:");
                Console.WriteLine("ВВедите а:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a >= 10 && a <= 99)
                {
                    b = 1;
                }
            }
            Console.WriteLine(Math.Pow(a % 10, 2)%10);




            Console.WriteLine("задание 1.2");
            Console.WriteLine("Введите e:");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите z:");
            z = Convert.ToInt32(Console.ReadLine());
            if (z <= 0)
            {
                x = Math.Pow(z, 2)+5;
            }
            else
            {
                x = 1 / (Math.Sqrt(z - 1));
            }
            numeral_sin = (Math.Sin(Math.Pow(x, 2))-1);
            y = Math.Pow(numeral_sin, 2) + Math.Log(Math.Abs(x), Math.E) + Math.Pow(e, x);
            Console.WriteLine(y);





            Console.WriteLine("задание 2");
            Console.WriteLine("Введите u: ");
            u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                v = Math.Pow(u, j);
                j += 2;
                k += (1 / v);
            }

            Console.WriteLine(k);


        }
    }
}