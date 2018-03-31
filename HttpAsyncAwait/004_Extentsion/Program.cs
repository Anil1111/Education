using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Рaсширяющик методы (Extension methods) - реализует идею динамического наследования.
//Рекурсия простая
namespace _004_Extentsion
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value, int counter)
        {
            counter--;
            Console.WriteLine(value+counter);
            if(counter!=0)
                value.ExtensionMethod(counter);
            Console.WriteLine(value+counter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello ";
            text.ExtensionMethod(5);

            //Delay
            Console.ReadKey();
        }
    }
}
