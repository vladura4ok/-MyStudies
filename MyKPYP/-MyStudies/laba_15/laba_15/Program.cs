using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            string path = @"/Users/VlaD/Desktop/avto.txt";
            string[] mass = File.ReadAllLines(path);
            Console.Write("Ввдете номер цеха: ");
            string tex = Console.ReadLine();
            Console.WriteLine();
            List<int> result  = new List<int>();
            for (int i = 0; i < mass.Length; i++)
            {
                string[] newMass = mass[i].Split(" ");
                result.Add(Convert.ToInt32(newMass[1]));
            }
            result.Sort();
            result.Reverse();
            
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    string[] newMass = mass[j].Split(" ");
                    if (result[i] == int.Parse(newMass[1]) && tex == newMass[2])
                        Console.WriteLine(mass[j]);
                }
            }

        }
    }
}
