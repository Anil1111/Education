using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Anonymous
{
    class MyClass
    {
        public int field;
        public void Method() => Console.WriteLine(field);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new { My = new MyClass() };
            instance.My.field = 1;
            instance.My.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
