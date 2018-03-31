using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Extentsion
{//Рaсширяющик методы (Extension methods) - реализует идею динамического наследования.
    //Аргумент расширения ВСЕГДА должен БЫТЬ ТОЛЬКО ОДНИН И СТОЯТЬ ПЕРВЫМ В СПИСКЕ АРГУМЕНТОВ.
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1+value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello ";
            text.ExtensionMethod("World!");

            //Delay
            Console.ReadKey();
        }
    }
}
