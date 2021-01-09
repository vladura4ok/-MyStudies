using System;

namespace PracticumLaba_13
{
    public delegate int IntOperation(int i, int j);
    public class MyClass
    {
        public event IntOperation my;

        public int InvokeEvent(int i, int j)
        {
            Console.WriteLine();
            Console.WriteLine("Результат евента: ");

            return my.Invoke(3, 3);
        }
    }
    class OneClass
    {
        public int Prz(int n, int u)
        {

            int result = n * u ^ 2;
            Console.WriteLine("Результат: " + result);
            return result;

        }

        public int Vich(int w, int t)
        {
            int result = 2 * w - t;
            Console.WriteLine("Результат: " + result);

            return result;
        }
    }
    class DoubleClass
    {
        public int Mt(int x, int k)
        {
            int result = Math.Abs(x) - k;
            Console.WriteLine("Результат: " + result);
            return result;
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            IntOperation io1;
            DoubleClass dCl = new DoubleClass();

            OneClass oCl = new OneClass();

            io1 = oCl.Prz;
            io1 += oCl.Vich;
            io1 += dCl.Mt;

            io1(20, 20);


            mc.my += io1;
            mc.InvokeEvent(3, 4);
        }
    }
}