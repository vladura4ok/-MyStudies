using System;

namespace laba5
{



    namespace ConsolTest
    {
        class BUS
        {
            string Fio;
            public string fio { get { return Fio; } set { Fio = value; } }
            string Bus;
            public string bus { get { return Bus; } set { Bus = value; } }
            int Rout;
            public int rout { get { return Rout; } set { Rout = value; } }
            string Marka;
            public string marka { get { return Marka; } set { Marka = value; } }
            int Data;
            public int data { get { return Data; } set { Data = value; } }
            int Probeg;
            public int probeg { get { return Probeg; } set { Probeg = value; } }
            public BUS()
            {
                Console.Write("ФИО = ");
                fio = (Console.ReadLine());
                Console.Write("Номер автобуса = ");
                bus = Console.ReadLine();
                Console.Write("Маршрут = ");
                rout = Convert.ToInt32(Console.ReadLine());
                Console.Write("Марка = ");
                marka = Console.ReadLine();
                Console.Write("Возраст = ");
                data = Convert.ToInt32(Console.ReadLine());
                Console.Write("Пробег = ");
                probeg = Convert.ToInt32(Console.ReadLine());

            }

            public void Show()
            {

                Console.WriteLine($"в итоге ФИО = {fio}, Номер автобуса = {bus}, Маршрут = {rout}, Марка = {marka}, Возраст = {data}, Пробег = {probeg}");
            }






            class Program
            {

                static void Main()
                {

                    Console.WriteLine("Количество автобус: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    BUS[] bUs = new BUS[n];
                    int i;

                    for (i = 0; i < n; i++)
                    {
                        bUs[i] = new BUS();
                        bUs[i].Show();

                    }


                    for (i = 0; n > i; i++)
                    {
                        if (bUs[i].data > 10) Console.WriteLine($"Автобус №{bUs[i].bus} возрастом старше 10 лет ");
                        if (bUs[i].probeg > 1000) Console.WriteLine($"Пробег у автосу №{bUs[i].bus} больше 10000км");
                    }

                    while (true)
                    {
                        Console.WriteLine("выберите номер маршрута:");
                        int m = Convert.ToInt32(Console.ReadLine());
                        for (i = 0; n > i; i++) if (bUs[i].rout == m) Console.WriteLine($"Атобус №{bUs[i].bus}, едет по маршруту №{bUs[i].rout}");


                    }
                }
            }
        }
    }
}