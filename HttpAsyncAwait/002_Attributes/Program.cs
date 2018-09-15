using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _002_Attributes.Attributes;

namespace _002_Attributes
{
    //public static int someField; - поле someField мы не можем использовать потому, что оно статическое
    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)] //ДЕКОРИРУЕМ(или помечаем) метод атрибутом MyAttribute
        public static void Method()
        {
            Console.WriteLine("MyClass.Mеthod()\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass.Method();

            //Анализ атрибутов:

            Type type = typeof(MyClass);

            //Анализ атрубутов типа:

            //Получаем все аттрибуты заданого типа MyAttribute
            // (false - без проверки базовых классов) - пример с рыбами прилипалы акулы мамы, бабушки и т.д
            //если у нас false - значит нас интересуют рыбы-прилипалы только одной акулы, без рыб-прилипал ее родственников.
            object[] attributes = type.GetCustomAttributes(false);

            foreach (MyAttribute attribute in attributes)
            {
                Console.WriteLine($"Анализ типа    : Number = {attribute.Number}, Date = {attribute.Date} ");
            }

            //Анализ атрибутов метода.

            //Получаем public static метод - Method
            MethodInfo methodInfo = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);
            
            //Получаем все аттрибуты данного метода 
            //(false - без проверки базовых классов).
            attributes = methodInfo.GetCustomAttributes(typeof(MyAttribute), false);

            foreach (MyAttribute attribute in attributes)
            {
                Console.WriteLine($"Анализ метода  : Number = {attribute.Number}, Date = {attribute.Date} ");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
