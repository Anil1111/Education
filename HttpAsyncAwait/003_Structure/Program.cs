using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры
namespace _003_Structure
{
    struct MyStruct
    {
        public int field;
        public static int field2;
        public string name;

        //Конструторы по умолчанию нельззя задавать явно.
        //public MyStruct()
        //{
        //}
        //Если в структуре имеются ПОЛЬЗОВАТЕЛЬСКИЙ конструктор, то требуется в нем 
        //инициализировать ВСЕ поля. (не считая static полей)
        public MyStruct(int value,string name) //даже если я создал пользовательский конструктор, ТО
        {                                      //конструктор ПО УМОЛЧАНИЮ У МЕНЯ ВСЕ РАВНО ЕСТЬ, а в классах  по-другому.
            Console.WriteLine("Constructor");
            this.field = value;
            this.name = name; //comment this
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра структурного типа с вызовом конструткора по умолчанию.
            MyStruct instance = new MyStruct();

            Console.WriteLine(instance.field);

            MyStruct instance2 = new MyStruct(1,"vasya");
            Console.WriteLine(instance2.field+instance2.name);

            //Delay
            Console.ReadKey();

        }
    }
}
