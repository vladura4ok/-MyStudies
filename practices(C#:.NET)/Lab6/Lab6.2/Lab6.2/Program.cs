using System;
using System.Collections.Generic;
using System.Linq;

class Complex
{
    public static void Main()
    {
        double[] array = { 1.0, 2.0, -5.0, 10.0, 0.0, 13.0, -25.0, -0.5 };
        // минимальный по модулю
        var modules = from num in array
                      select Math.Abs(num);
        double min = modules.Min();
        Console.WriteLine("Минимальный по модулю: {0}", min);

        // сумма чисел после нуля
        bool isFirstZeroFinded = false;
        double sum = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            // если первый ноль найден, то начинаем сложение
            if (isFirstZeroFinded)
                sum += array[i];
            if (array[i] == 0.0)
                isFirstZeroFinded = true;
        }
        Console.WriteLine("Сумма чисел после нуля: {0}", sum);

        // в начале массива - элементы из чётных позиций
        // собираем значения из чётных индексов
        List<double> evens = new List<double>();
        for (int i = 1; i < array.Length; i += 2)
        {
            evens.Add(array[i]);
        }
        // элементы из нечётных индексов - это оставшиеся
        var non_evens = array.Distinct();
        // объединяем всё вместе
        var result = evens.Union(non_evens);
        Console.Write("Сначала из чётных индексов, затем из нечётных: {");
        foreach (double d in result)
        {
            Console.Write(d);
            Console.Write(", ");
        }
        Console.Write("}\n");
    }
}