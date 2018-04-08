using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Находим элемент перечисления ПО ИМЕНИ КОНСТАНТЫ
            //BOXING
            object element = Enum.Parse(typeof(MyEnum), "Infinite");
            //UnBoxing
            MyEnum number = (MyEnum) element;
            
            Console.WriteLine($"Значение константы {number} : {(byte)number}");

            //Enum.IsDefined() - Позволяет определить, является ли символьная строка элементом перечисления?
            //bool flag = Enum.IsDefined(typeof(MyEnum), "one");
            bool flag = Enum.IsDefined(typeof(MyEnum), "onexxxxxxxxxxx");

            if (flag == true)
                Console.WriteLine("Да, перечисление сожержит элемент с таким именем.");
            else
                Console.WriteLine("Нет, перечисление не содержит элемент с таким именем.");

            //Delay
            Console.ReadKey();
        }
    }
}
