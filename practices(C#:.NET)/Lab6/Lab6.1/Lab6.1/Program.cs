using System;

namespace Lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool es = true;
            int i;
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите эллемент: ");
            int x = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[n];
            for(i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0,10);
                //Console.WriteLine(arr[i]);
                if (x == arr[i])
                {
                    es = false;
                    Console.WriteLine(i);
                }
                else
                {
                    es = true;
                    Console.WriteLine($"Эллемента {x} в массиве нет!");
                }
            }
            
        }
    }
}
