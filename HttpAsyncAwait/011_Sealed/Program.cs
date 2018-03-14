using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Sealed
{//Герметизированные классы!!
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    //Попытка наследования от SealedClass приводит к ошибке уровня компиляции.
    class DerivedClass//: SealedClass     //Error!
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass instance = new SealedClass();
            instance.x = 100;
            instance.y = 200;

            Console.WriteLine($"x = {instance.x}, y = {instance.y}");

            //Delay
            Console.ReadKey();
        }
    }
}
