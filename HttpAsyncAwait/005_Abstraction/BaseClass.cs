using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Abstraction
{
    abstract class AbstractBaseClass
    {
        //1.
        //Обычный метод передается производному классу как при наследовании от конкретного класса
        //можем земестить
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }

        //2.
        //Виртуальный метод передается производному классу как при наследовании от конкрентого класса.
        //можем переопределить, земестить(если не указать override, то там будет отдельная форма перекрытия)
        public virtual void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }

        //3
        //Абстрактный метод - реализуется в производном классе.
        //Технически  - мы переопределим т.к абстрактных методов не существует и это обычный virtual метод с пустым телом
        //но лучше говорить, что мы реализуем абстракцию!
        public abstract void AbstractMethod();
    }
}
