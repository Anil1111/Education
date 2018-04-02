using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Статический конструктор
//СТРУКТУРЫ МОГУТ ИМЕТЬ СТАТИЧЕСКИЙ КОНСТРУКТОР
namespace _006_Structure_Static_Constructor
{
    struct MyStruct //В этой структуре сейчас 3 конструктора: два видно и один по умолчанию.
    {
        public int field;

        //Статический конструктор
        static MyStruct()
        {
            Console.WriteLine("Static Constructor");
        }
        //если в структуре имеется пользовательский конструктор, то требуется в нем проинициализировать все поля.
        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.field = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра структурного типа, с вызовом КОНСТРУТКОРА ПО УМОЛЧАНИЮ.
            MyStruct instance = new MyStruct(){field = 0}; //статический конструткор не отработал

            MyStruct instance2 = new MyStruct(5); //тут статический конструктор отработает в связке с пользовательским конструктором.
                                                  //статический констуктор НЕ будет работать в связке к конструктором ПО УМОЛЧАНИЮ.
            Console.WriteLine(instance.field);

            //Delay
            Console.ReadKey();

        }
    }
}
