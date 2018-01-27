using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проинициализируем все переменные значением по умолчанию
            bool b = new bool();
            int i = new int();
            float f = new float();
            char c = new char();
            string str = default(string);

            Console.WriteLine("Переменная b =" + b);
            Console.WriteLine("Переменная i =" + i);
            Console.WriteLine("Переменная f =" + f);

            if (c == '\0')
                Console.WriteLine("Переменная с = нулевому символу");
            if (str == null)
                Console.WriteLine("Переменная str==null");

            //Delay
            Console.ReadKey();
        }
    }
}
