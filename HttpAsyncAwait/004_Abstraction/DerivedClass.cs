using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Abstraction
{
    class ConcreteDerivedClass:AbstractBaseClass
    {
        //Переопределяем виртуальный метод VirtualMethod() базового абстрактного класса.
        //Если мы не переопределим виртуальный метод, то будет использован метод из базового класса
        public override void VirtualMethod()   //если не переопределить этот метод, 
                                               //в этом класса останется метод,унаследованный из базового класса
        {
            Console.WriteLine("ConcreteDerivedClass.VirtualMethod");
        }

        //Реализуем абстрактный метод AbstractMethod базового абстрактного класса.
        public override void AbstractMethod()
        {
            Console.WriteLine("ConcreteDerivedClass.AbstractMethod");
        }
    }
}
