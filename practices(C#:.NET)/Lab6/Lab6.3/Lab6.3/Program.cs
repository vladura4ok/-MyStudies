﻿using System;

namespace Lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas[i, j] = -5 + rnd.Next(15);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            //подсчет локальных минимумов
            int count = 0;
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (mas[i - 1, j] > mas[i, j] && mas[i + 1, j] > mas[i, j])
                        if (mas[i, j - 1] > mas[i, j] && mas[i, j + 1] > mas[i, j])
                            count++;
                }
            }
            Console.WriteLine("Количество локальных минимумов: " + count);
            //сумма модулей элементов, расположенных выше главной диагонали
            int summa = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    summa += Math.Abs(mas[i, j]);
                }
            }
            Console.WriteLine("Сумма модулей элементов, расположенных выше главной диагонали = " + summa);
            Console.ReadKey();
        }
    }
}
