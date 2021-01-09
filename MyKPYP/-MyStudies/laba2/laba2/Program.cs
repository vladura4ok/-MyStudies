using System;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат 1 задания 9 варианта:");
            Console.WriteLine(Math.Cos(x) / (Math.PI - 2 * x) + 16 * x * Math.Cos(x * y) - 2);


            int R, r;
            Console.WriteLine("Введите R:");
            R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите r:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат 2 задания 9 варианта:");
            Console.WriteLine(Math.PI * (Math.Pow(R,2)- Math.Pow(r, 2)));
        }
    }
}
