using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object();
            // GetType() - возращает ссылку на экземпляр класса Type, который нам выдаст всю информацию
            // о типе того обьекта(экземпляра), на котором и был вызван этот метод.
            Type type = obj.GetType();

            Console.WriteLine(type);
            Console.WriteLine(type.ToString());

            //Delay
            Console.ReadKey();
        }
    }
}
