using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Structure
{
    struct MyStruct
    {
        public int field;

        public MyStruct(int value)
        {
            this.field = value;
            Console.WriteLine(this.field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра структурного типа БЕЗ вызова конструктора.
            MyStruct instance;

            //Нельзя использовать не инициалированную переменную.
            //Так, как конструктор не вызывался, переменная field осталась не прининицализированной!
            //Console.WriteLine(instance.field);  //убрать комментарий.

            MyStruct instanceWithConstructor = new MyStruct(555);
            Console.WriteLine(instanceWithConstructor.field); // - так все ок, потому, что мы использовали конструктор.

            //Delay
            Console.ReadKey();
        }
    }
}
