using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_base.Method
{
    class DerivedClass: BaseClass
    {
        //Переопределение метода базового класса.
        public override void Method()
        {
            //Вызов метода базового класса
            base.Method();   //если мы уберем base. то это будер равносильно this.
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
