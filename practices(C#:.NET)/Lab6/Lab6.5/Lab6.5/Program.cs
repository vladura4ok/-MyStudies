using System;

namespace Lab6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину массива: ");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[t, m];
            Random rnd = new Random();
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = -5 + rnd.Next(15);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            //подсчет локальных минимумов
            int count = 0;
            for (int i = 1; i < t-1; i++)
            {
                for (int j = 1; j < m-1; j++)
                {
                    if (mas[i - 1, j] > mas[i, j] && mas[i + 1, j] > mas[i, j] && mas[i, j - 1] > mas[i, j] && mas[i, j + 1] > mas[i, j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Количество локальных минимумов: " + count);
            //сумма модулей элементов, расположенных выше главной диагонали
            int summa = 0;
            for (int i = 0; i < t; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    summa += Math.Abs(mas[i, j]);
                }
            }
            Console.WriteLine("Сумма модулей элементов, расположенных выше главной диагонали = " + summa);
            Console.ReadKey();
        }
    }
}
