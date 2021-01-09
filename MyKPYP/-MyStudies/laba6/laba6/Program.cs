using System;

namespace laba6
{
    class Program
    {


        static void Metod(int[] n)
        {
            int cum =1;
            bool minus = false;
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {

                Console.Write(n[i]+ " "); 
                if(n[i]<0)
                {
                    minus = true;
                    cum *= n[i];
                }


            }
            Console.WriteLine();
            if (minus)
            {
                Console.WriteLine(cum);
            }
            else
            {
                Console.WriteLine("Нет отрицательных элементов");


            }

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int[] MyArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                MyArray[i] = int.Parse(Console.ReadLine());


            }
            int sum = 0, counter = 0,  index = 0, min = MyArray[0];
            Console.WriteLine("Вывод массива :");
            for (int i = 0; i <n; i++)
            {
                
                if(counter == 1)
                {
                    sum += MyArray[i];

                }
                if (MyArray[i] < 0)
                {
                    counter++;
                }
                if (min > MyArray[i])
                {
                    min = MyArray[i];
                    index = i;
                }
            
                Console.Write(MyArray[i] + " ");
           
            }
            int temp;
            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (Math.Abs(MyArray[i]) > Math.Abs(MyArray[j]))
                    {
                        temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сортированный :");
            for (int i = 0; i < n; i++)
            {

                Console.Write(MyArray[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine($"{min} под номером {index}");
            Console.WriteLine($"сумма {sum}");
            int[] MyArray_1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите элемент");
                MyArray[i] = int.Parse(Console.ReadLine());


            }
            Metod(MyArray_1);
        }
    }

}
