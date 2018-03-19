using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interfaces
{
    class DerivedClass : IInterface1, IInterface2, IInterface3  //множественное наследование абстракции
    {
        //На 16-й строке реализуем метод с именем Method из базового интерфейса IInterface1
        //При реализации метода используем ТЕХНИКУ ЯВНОГО УКАЗАНИЯ ИМЕНИ ИНТЕРФЕЙСА В ИМЕНИ МЕТОДА
        //которому принадлежит метод, например IInterface1.Method()

        //По-умолчанию ОДНОИМЕННЫЕ МЕТОДЫ ЯВЛЯЮТСЯ PRIVATE!, НО явно указывать модификаторы доступа недопустимо!
        void IInterface1.Method()
        {
            Console.WriteLine("Реализация метода Method() из IInterface1");
        }

        void IInterface2.Method()
        {
            Console.WriteLine("Реализация метода Method() из Interface2");
        }

        public void Method3()
        {
            Console.WriteLine("Реализация метода Method3() из Interface3");
        }
    }
}
