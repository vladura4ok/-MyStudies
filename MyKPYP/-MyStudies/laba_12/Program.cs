using System;

namespace LabaKPu9IP_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] mass = new int[5];

                Console.WriteLine("Введите 5 чисел: ");
                for (int i = 0; i < 5; i++)
                {
                    mass[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;
                int count = 0;

                for (int i = 0; i < 5; i++)
                {

                    if (mass[i] != 0)
                    {
                        sum += mass[i];
                        count++;
                    }
                }

                Console.WriteLine("Среднее арифметическое: " + sum / count);
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}