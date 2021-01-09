using System;

namespace practice_2
{
    class Program
    {
        static int C(int n, int m)
        {
            if ((m == 0 && n > 0) || (m == n && n >= 0))
            {
                return 1;
            }

            else if (m > n && n > 0)
            {

                return 0;
            }
            else
            {
                return C(n - 1, m - 1) + C(n - 1, m);

            }
        }

        static void Main(string[] args)
        {
            double a = -0.5, b = 1.7, t = 0.44,y,s;
            y = Math.Pow(Math.E, -b * t)*Math.Sin(a*t+b)- Math.Sqrt(b*t+a);
            Console.WriteLine(y);
            s = b * Math.Sin(Math.Pow(a * t, 2) * Math.Cos((2 * t)) - 1);
            Console.WriteLine(s);

            Console.WriteLine("Введите m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(C(m, n));

        }
    }
}
