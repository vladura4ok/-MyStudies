using System;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            double a, b, d;
            char c;

            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите действие (+, -, *, /): ");
            c = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            switch (c)
            {
                case '+': 
                    d = a + b; 
                    Console.WriteLine(a + " + " + b + " = " + d); 
                    break;
                case '-': 
                    d = a - b; 
                    Console.WriteLine(a + " - " + b + " = " + d); 
                    break;
                case '*': 
                    d = a * b; 
                    Console.WriteLine(a + " * " + b + " = " + d); 
                    break;
                case '/': 
                    d = a / b; 
                    Console.WriteLine(a + " / " + b + " = " + d); 
                    break;
            }
            Console.ReadLine();
        }
    }
}