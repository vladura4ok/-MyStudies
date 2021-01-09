using System;
using System.Linq;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            string straka = Console.ReadLine();
            string[] words = straka.Split();
            int max = 0;
            string slovo = " "; 
            foreach(string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    slovo = word;
                }
                
            }

            char[] slovos = new char[max];
            for (int i = 0; i < max; i++)
            {
                slovos[i] = slovo[i];
                if (slovos[i] == 'a')
                    slovos[i] = 'b';

            }
            for (int i = 0; i < max; i++)
            {
                Console.Write(slovos[i]);
            }
            Console.WriteLine();
            string str = "МАМА МЫЛА РАМУ ЗА ОКНОМ ШЕЛ ДОЖДЬ";
            bool d = true;
            int s = 0;
            for (int i = 0; i<str.Length; i++)
            {
                if(str[i] == 'А' && d)
                {
                    s++;
                    d = false;
                }
                if (str[i] == ' ')
                {
                    d = true;
                }

            }
            Console.WriteLine(s);

        }
    }
}
