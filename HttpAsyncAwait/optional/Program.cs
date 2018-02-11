using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional
{
    class Program
    {
        const string phrase  = "Hello"; //Константу можно впихнуть в аргументные скобки метода, 
        //а поле, свойство - нет!
        static void MyMethod(string s = phrase, int a = 10, bool b = false )
        //(bool b ,string s = "Hello", int a = 10 ) опциональные параметры должны идти после
        //обычных параметров!
        {
            Console.WriteLine($"{s},{a},{b}");
        }
        static void Main(string[] args)
        {
            bool boolValue = true;
            int intValue = 5556;
            MyMethod();
            MyMethod("Something");
            MyMethod(a:45);
            MyMethod("SSD ГДЕ?",b: boolValue, a: intValue);

            //Delay
            Console.ReadKey();
        }
    }
}
