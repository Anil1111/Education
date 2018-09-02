using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_StringWriter
{
    class Program
    {
        //Запись в поток
        static void Main(string[] args)
        {
            //StrinWriter - обертка над StringBiulder
            var writer = new StringWriter();
            writer.WriteLine("Hello all");
            writer.Write("This is a multi-line");
            writer.WriteLine(" text string");

            //Сделали стрингу, а теперь можно заставить записать ее в какой-то Stream, или вывести ее:
            Console.WriteLine(writer.ToString());

            //Delay
            Console.ReadKey();
        }
    }
}
