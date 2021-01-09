using System;

namespace practice_3
{
    class ClassLibrary
    {
        public int number;

        public void GetInfo()
        {
            bool proverka = true;
            int vibor;
            Console.WriteLine($"Ваше число: {number}");
            if(number%2==0)
            {
                string s = Convert.ToString(number);
                Console.Write("Палиндром вашего числа: " + s);
                for (int i = 3; i >= 0; i--)
                Console.Write(s[i]);
            }
            else
            {
                int[] mass = new int[4];
              for(int i = 3; i >=0; i--)
                {
                    mass[i] = number % 10;
                    number /=10;
                }

                while (proverka) {
                    Console.WriteLine("Ваше число не четное, выберете действие\n1)Вывести по возрастанию 2)Вывести по убыванию");
                    vibor = int.Parse(Console.ReadLine());
                    if (vibor == 1)
                    {

                        Array.Sort(mass);
                        for(int i =0; i<4; i++)
                        {
                            Console.Write(mass[i]);
                        }
                        proverka = false;
                    }
                    else if (vibor == 2)
                    {

                        Array.Sort(mass);
                        Array.Reverse(mass);
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write(mass[i]);
                        }
                        proverka = false;
                    }
                    else
                    {
                        proverka = true;
                    }
                }
            
            }

        }
    }
    class ClassTest 
    {
        static void Main(string[] args)
        {
            bool proverka = true;
            ClassLibrary tom = new ClassLibrary();
            while (proverka)
            {
                Console.WriteLine("Введите четырехзначное число: ");
                tom.number = int.Parse(Console.ReadLine());
                if (tom.number < 10000 && tom.number > 999)
                {
                    tom.GetInfo();
                    proverka = false;
                }
            }
        }
    }
    
}
