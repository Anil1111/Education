using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Virtual
{
    class DerivedClass:BaseClass
    {
        //Переопределение метода базового класса, НО НЕ МЕНЯЯ СИГНАТУРУ ЭТОГО МЕТОДА. Только реализацию
        public  override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }

        //так же мы можем заместить этот метод! просто не указыть слово override и указать слово new!
        //если раскоменчивать этот метод, то нужно закоментить метод, который выше
        //public new void Method()
        //{
        //    Console.WriteLine("Method from DerivedClass");
        //}
    }
}
