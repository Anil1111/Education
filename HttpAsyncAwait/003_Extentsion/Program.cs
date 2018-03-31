using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Рaсширяющик методы (Extension methods) - реализует идею динамического наследования.
//Расширяющие методы МОГУТ ИМЕТЬ ОПЦИОНАЛЬНЫЕ ПАРАМЕТРЫ, И могут быть перегруженны.
namespace _003_Extentsion
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value1)
        {
            Console.WriteLine(value1);
        }
        public static void ExtensionMethod(this string value1, string value2,string value3 ="abra-kadabra")
        {
            Console.WriteLine(value1+value2+ value3);
        }
        public static void ExtensionMethod(this int value1, int a = 50)
        {
            Console.WriteLine(value1+a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello";

            text.ExtensionMethod("world");

            "Hello ".ExtensionMethod("world!");
            2.ExtensionMethod(30);

            //Delay
            Console.ReadKey();
        }
    }
}
