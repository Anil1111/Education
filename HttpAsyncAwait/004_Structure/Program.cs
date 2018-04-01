using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры.
namespace _004_Structure
{
    struct MyStruct
    {
        public int field;

        //Конструкторы по умолчанию НЕЛЬЗЯ создавать в структурах. Они и там там вседа есть.
        //public MyStruct()
        //{
        //}

        //Если в структуре имеется пользовательский конструктор, то требуется в нем инициализировать все поля.
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
            //Создание экземпляра структурного типа, с вызовом пользовательского конструктора.
            MyStruct instance = new MyStruct(20);

            Console.WriteLine(instance.field);

            //Delay
            Console.ReadKey();
        }
    }
}
