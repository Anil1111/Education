using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_MSDN
{
    //Контекст
    // В следующих ситуациях ключевое слово dynamic может отображаться как есть или как компонент сконструированного типа:

    //В объявлениях: как тип свойства, поля, индексатора, параметра возвращаемого значения, локальной переменной или ограничения типа.
    //В представленном ниже определении класса ключевое слово dynamic используется сразу в нескольких различных объявлениях.
    class ExampleClass
    {
        // A dynamic field.
        static dynamic field;

        // A dynamic property.
        dynamic prop { get; set; }

        // A dynamic return type and a dynamic parameter type.
        public dynamic exampleMethod(dynamic d)
        {
            // A dynamic local variable.
            dynamic local = "Local variable";
            int two = 2;

            if (d is int)
            {
                return local;
            }
            else
            {
                return two;
            }
        }
    }
    class Program
    {
        static void convertToDynamic()
        {
            //В явных преобразованиях типа: как целевой тип преобразования.
            dynamic d;
            int i = 20;
            d = (dynamic)i;
            Console.WriteLine(d);

            string s = "Example string.";
            d = (dynamic)s;
            Console.WriteLine(d);

            DateTime dt = DateTime.Today;
            d = (dynamic)dt;
            Console.WriteLine(d);
            // Results:
            // 20
            // Example string.
            // 2/17/2009 9:12:00 AM

            //В любом контексте, где типы служат в качестве значений, например справа от оператора is или as, 
            //либо в качестве аргумента для typeof в рамках сконструированного типа.
            //Например, ключевое слово dynamic можно использовать в следующих выражениях:
        }
        static void Main(string[] args)
        {
           convertToDynamic();
            int i = 8;
            dynamic d;
            var someVar = 1;
            // With the is operator.
            // The dynamic type behaves like object. The following
            // expression returns true unless someVar has the value null.
            if (someVar is dynamic) { }

            // With the as operator.
            d = i as dynamic;

            // With typeof, as part of a constructed type.
            Console.WriteLine(typeof(List<dynamic>));

            // The following statement causes a compiler error.
            //Console.WriteLine(typeof(dynamic));

            Console.WriteLine(default(dynamic) == null ? "Null" : "????"); //returns Null
        }
    }
}
