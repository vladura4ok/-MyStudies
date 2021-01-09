using System;

namespace laba14
{
    class Program
    {
        public delegate void EventDelegate();
        public class Class2
        {

            public event EventDelegate myEvent = null;
            public double Method3(double p)
            {
                myEvent.Invoke();
                double e = Math.Exp(p);
                return e;

            }
            public void InvokeEvent()
            {
                myEvent.Invoke();
            }
        }

        public delegate double MyDelegate(double w);

        static void Main()
        {
            MyDelegate myDelegate = Method1;
            Class2 class2 = new Class2();

            Console.WriteLine(myDelegate(5));
            myDelegate += Method2;
            Console.WriteLine(myDelegate(5));
            myDelegate += class2.Method3;
            class2.myEvent += new EventDelegate(Handler);
            Console.WriteLine(myDelegate(2));




        }
        public static double Method1(double w)
        {
            w = Math.Sqrt(w);
            return w;
        }
        public static double Method2(double H)
        {
            H = Math.Pow(H, 2) + 5;
            return H;
        }
        static private void Handler()
        {

            Method1(5);
            Method2(5);
            Console.WriteLine("Метод 3 выполнен");
        }
    }

}