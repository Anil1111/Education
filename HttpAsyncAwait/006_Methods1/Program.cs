using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Methods1
{
    class Program
    {//Возврат значения из метода Main()
        //Перегрузка метода Main() - допустима.
        //Точкой входа в программу может быть метот Main(), который возвращает значение типа void или int.

        //Перегрузка. (Не является точкой входа)
        static string Main(string argument)
        {
            return "Hello " + argument + "!";
        }
        //Точка входа в программу т.к (string[] args) или просто ()
        //static void main() // если поставлю (string[] args) или просто (), то будет 2 точки входа в программу!
        //{
        //    console.writeline("sdfdfd");

        //    //delay
        //    console.readkey();
        //}
        //Точка входа в программу
        static int Main(string[] args)
        {
            string @string = Main("World");
            Console.WriteLine(@string);

            //Delay
            Console.ReadLine();
            return 0;
        }
    }
}
