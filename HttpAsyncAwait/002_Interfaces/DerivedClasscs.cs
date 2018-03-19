using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Interfaces
{
    class DerivedClasscs:IInterface1,IInterface2  //множественное наследование абстракции
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из IInterface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2");
        }
    }
}
