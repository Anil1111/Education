using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры.
//В структурах можно создавать автоматически реализуемые свойства,
// при этом требуется использовать конструктор при построении экземпляра.
namespace _008_Structure_AutoProperty
{
    struct MyStruct
    {
        public int MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct instance = new MyStruct(); //без конструктора будет ошибка!

            //instance.MyProperty = 1;
            Console.WriteLine(instance.MyProperty);

            //Delay
            Console.ReadKey();
        }
    }
}
