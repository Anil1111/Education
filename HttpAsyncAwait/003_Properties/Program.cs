using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Properties
{
    //Классыю (Использование свойств, для доступа к закрытым полям.)

    //Свойство - интерфейс доступа к полю обьекта.
    //Свойства в С# - поля с логическим блоком, в котором есть ключевые слова get и set
    //и являются суррогатом для замены методов доступа к полю.
    //При обращении к свойству вызывается определенный метод, который выполняет определённые операции с обьекктом.
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set //void SetField(string value) - Метод-мутатор - mutator (setter)
            {
                if (value != "fool")
                    field = value;
            }
            get //string GetField()           - Метод-аксессор - accessor (getter)
            {
                return field;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Field = "Hello World";     // Метод-мутатор
            Console.WriteLine(instance.Field);  // Метод-аксессор

            //Delay
            Console.ReadKey();
        }
    }
}
