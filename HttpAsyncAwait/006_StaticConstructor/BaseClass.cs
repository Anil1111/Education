using System;

namespace _006_StaticConstructor
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Non static constructor from BaseClass");
        }

        static BaseClass()
        {
            Console.WriteLine("Static constructor from BaseClass");
        }
    }

    //Сначала вызывается статический конструктор класса наследника
    //потом статический конструктор класса родителя
    //потом экземплярный из класса родителя
    //и на конец - экземплчрный конструктор класса - наследника
}
