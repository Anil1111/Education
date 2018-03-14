using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_1_CombineVirtulAndNotVirtual
{
    class DerivedClass:BaseClass
    {
        //Переопределение метода базового класса
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }

        public new void NOTVIsrtualMethod() // Замещаем, а не переопределяем ЗАМЕЩЕНИЕ - ЭТО НЕ ПОЛИМОРФИЗМ!
        {
            Console.WriteLine("NOTVIsrtualMethod from DerivedClass");
        }
    }
}
