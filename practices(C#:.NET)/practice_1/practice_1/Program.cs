using System;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* double a = 1;
            int i = 0;
            for (i = 0; i < 3; i++)
            {
                a =+ 0.2;
                double z = (Math.Sin(Math.PI / 2 + 3 * a)) / (1 - Math.Sin(3 * a - Math.PI));
                Console.WriteLine(z);
            }
            while(i < 3)
            {
                i++;
                a = 0.2;
                double z = (Math.Sin(Math.PI / 2 + 3 * a)) / (1 - Math.Sin(3 * a - Math.PI));
                Console.WriteLine(z);
            }
            do
            {
                i++;
                a =+0.2;
                double z = (Math.Sin(Math.PI / 2 + 3 * a)) / (1 - Math.Sin(3 * a - Math.PI));
                Console.WriteLine(z);
            }
            while (i < 3);
            Console.WriteLine("Введите one: ");
                int one = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите two: ");
                int two = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите three: ");
                int three = int.Parse(Console.ReadLine());
            
            if(one > two && one > three)
            {
                Console.WriteLine("max/2:");
                Console.WriteLine(one/2);
            }
            else if (two > one && two > three)
            {
                Console.WriteLine("max/2:");
                Console.WriteLine(two/2);
            }
            else if (three > two && three > one)
            {
                Console.WriteLine("max/2:");
                Console.WriteLine(three/2);
            }
            else
            {
                Console.WriteLine("==");
            }
                
            if (one < two && one < three)
            {
                Console.WriteLine("min*3:");
                Console.WriteLine(one*3);
            }
            else if (two < one && two < three)
            {
                Console.WriteLine("min*3:");
                Console.WriteLine(two*3);
            }
            else if (three < two && three < one)
            {
                Console.WriteLine("min*3:");
                Console.WriteLine(three*3);
            }*/
            
            int sum;
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] myArr = new int[n, m];
            int[] C = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Введите элемент массива:");
                    myArr[i, j] = int.Parse(Console.ReadLine());
                    
                }
                
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    Console.Write(myArr[i,j]);

                }
                Console.WriteLine();
            }



            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = 0; j < n; j++)
                {
                    
                    sum = sum + myArr[i, j];
                }
                C[i] = sum;
            }
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write(C[i] + " ");
            }

        }
    }
}
