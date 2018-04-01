using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Если в сструктуре имеются члены, которые обращаются к полю и не пользовательчского конструктора,
// то требуется при создании экземпляра вызвать конструктор по умолчанию. (Иначе будет ошибка.)
namespace _002_Structure
{
    struct MyStruct //Наследуется от абстрактного класса ValueType, который в свою очередь - от Object
    {
        private int field;

        public int Field
        {
            get => field;
            set => field = value;
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра структурного типа с вызовом конструктора по умолчанию.
            MyStruct instance = new MyStruct(); //эта структура будет располагаться на КУЧЕ т.к мы использовали new
            // а адресс экземпляра структурного типа instance - будет в СТЕКЕ.

            instance.Field = 1; //Закоментировать - ошибки не будет! Почему, потому, что вызвали конструктор по умолчанию.
            
            Console.WriteLine(instance.Field);

            //Delay
            Console.ReadKey();
        }

        //Итог: мы можем создавать экземпляр структур как и вызовом конструктора так и без него.
        //Если без конструктора - то прежде чем использовать поля - нам нужно их проинициализировать.
    }
}
