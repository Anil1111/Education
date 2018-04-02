using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nested structures.
namespace _001_Nested1
{
    struct MyStruct
    {
        public struct Nested  //вложенная структура
        {
            public void Method()
            {
                Console.WriteLine("Method from Nested structure");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //указыаем ВЕСЬ путь вложенности
            MyStruct.Nested instance = new MyStruct.Nested();
            instance.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
