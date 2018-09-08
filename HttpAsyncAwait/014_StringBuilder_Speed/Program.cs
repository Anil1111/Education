using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _014_StringBuilder_Speed
{
    //использование StringBuilder и замеры производительности
    class Program
    {
        static void Main(string[] args)
        {
            string simpleString = String.Empty;

            Stopwatch time = new Stopwatch(); //можно было бы через DateTime замерять, как в примере, но это не так точно как с помощью Stopwatch

            time.Start();
            //Замер скорости построения обыных строк.
            for (int i = 0; i < 99999; i++)
            {
                simpleString += "a";
            }
            time.Stop();
            Console.WriteLine($"Обычная строка построилась за {time.Elapsed}");

            time.Reset();
            var builder = new StringBuilder();
            time.Start();
            //Замер скорости построения строк, с использванием StringBuilder
            for (int i = 0; i < 99999; i++)
            {
                builder.Append("a");
            }
            time.Stop();
            Console.WriteLine($"При помощи StringBuilder строка построилась за {time.Elapsed}");

            Console.WriteLine($"Длина обычной строки {simpleString.Length} символов");
            Console.WriteLine($"Длина StringBuilder строки {builder.ToString().Length} символов"); //String builder намного быстрее!!

            //Delay
            Console.ReadKey();
        }
    }
}
