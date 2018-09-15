using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Attributes
{
    [My("XXXXX", "XXXXX")]
    class BaseClass { }

    //Можно и так, никаких проблем не будет (множественное декорирование - в одной секции используется 2 атрибута)
    //[My("First", "31/01/2008"), My("Second", "31/01/20089")]

    //Ошибки нету потому, что AllowMultiple = true
    [My("First", "31/01/2008")]
    [My("Second", "31/01/20089")]
    class MyClass : BaseClass { }
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);

            //берем все аттрибуты С УЧЕТОМ БАЗОВЫХ КЛАССОВ, потому, что inherit = true
            object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true);

            foreach (MyAttribute attribute in attributes)
            {
                Console.WriteLine($"{attribute.Text}, {attribute.Data}");
                attribute.Method(); //Вызываем метод аттрибута
            }

            //Delay
            Console.ReadKey();
        }
    }
}
