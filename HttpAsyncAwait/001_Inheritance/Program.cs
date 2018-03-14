using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{// Наследовани.
    //Наследование - механизм обьектно-ориентированного программирования, позволяющий описать новый ( производный)
    //класс на основе уже существующего(базового)
    //при этом свойства и функцмональность базового класса заимствуется новым произвожным клссом.
    
    //Базовый класс                  -             Производный класс
    //Супер класс                    -             Подкласс или (сабкласс)
    //Родительский класс             -             Дочерний класс
    //Родитель                       -             Потомок
    class Program
    {
        static void Main(string[] args)
        {
            var firstInstance = new DerivedClass();
            Console.WriteLine(firstInstance.publicField);
            //Console.WriteLine(firstInstance.protectedField)  Нельзя!

            var secondInstance = new SecondDerivedClass();
            Console.WriteLine(secondInstance.publicField);
            //Console.WriteLine(secondInstance.protectedField);  Нельзя!

            //Delay
            Console.ReadKey();
        }
    }
}
