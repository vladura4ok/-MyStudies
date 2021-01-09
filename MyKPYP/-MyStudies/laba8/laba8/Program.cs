using System;
using System.Collections.Generic;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите начало диапазона");
            double begin = 0.1;//double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите конец диапазона");
            double end = 1.1;//double.Parse(Console.ReadLine());
            double result = 0;
            double x = begin;
            List<double> results = new List<double>();
            for(int i = 0; i < (end / begin); i++)
            {
                result = 2 * x - Math.Cos(end);
                results.Add(result);
                x += begin;
            }

            foreach(double i in results)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            bool Binary(double a, double c)
            {
                bool check = false;
                if((results[Convert.ToInt32(a/a)] * results[Convert.ToInt32(c / a)]) < 0)
                {
                    check = true;
                }
                return check;
            }

            void Search(double a, double b)
            {
                List<double> newResults = new List<double>();
                double c = Math.Round(((a + b) / 2), 1);
                Console.WriteLine(c);
                if(Binary(a, c,))
                {
                    Console.WriteLine("daa");
                    for (int i = 0; i < (a/c); i++)
                    {

                    }
                    b = c;
                    Search(a, b);

                }
  
                Console.WriteLine(results[Convert.ToInt32(begin / begin)]);
                Console.WriteLine(results[Convert.ToInt32(c / a)]);


            }
            Search(begin, end);
        }
    }
}
