using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры. Наследование.
// Все структуры неявно неследуются от АБСТРАКТНОГО КЛАССА - ValueType.
namespace _002_Inheritance2
{
    struct MyStruct //: ValueType
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct instance = new MyStruct();
            ValueType valueType = instance as ValueType;

            Console.WriteLine($"instance = {instance.GetHashCode()}");
            Console.WriteLine($"valueType = {valueType.GetHashCode()}");
            //хэш коды одинаковы, это говорит о том, что произошло ПРАВИЛЬНОЕ ПРИВЕДЕНИЕ!
            //если что, то в файле с именем 013_RealPolymorphism есть пример с разными hash кодами.

            //Delay
            Console.ReadKey();
        }
    }
}
