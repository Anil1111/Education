using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_VeryExcitingExample
{
    abstract class AbstractClass
    {
        //Статический фабричный метод.
        public static AbstractClass CreateObject() 
        {
            return new ConcreteClass(); //Вернул и СРАЗУ ЖЕ привел тип ConcreteClass к типу AbstractClass!
        }                               //А знает AbstractClass о  ConcreteClass т.к они лежат в одном namespace.

        public abstract void Method();
    }
}
