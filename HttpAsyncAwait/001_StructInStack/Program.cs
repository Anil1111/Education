using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_StructInStack
{
    class MyClass
    {
        public MyStruct_1mb st = new MyStruct_1mb();   //НА КУЧЕ!
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            MyStruct_1mb my = new MyStruct_1mb();  //НА СТЕКЕ  т.к это локальная переменная метода.
            Console.WriteLine(GC.GetTotalMemory(false));  
            Console.WriteLine(my.GetType());

            MyStruct_16kb [] array = new MyStruct_16kb[64]; //НА КУЧЕ! даже не смотря на то, что 
            Console.WriteLine(array.GetType());             //это локальная переменная!! ТОЛЬКО ССЫЛКА НА массив array в стеке.
            Console.WriteLine(GC.GetTotalMemory(false));

            Console.WriteLine(my);
            Console.WriteLine(GC.GetTotalMemory(false));
            //Delay
            Console.ReadKey();
        }
    }
}
