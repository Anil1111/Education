using System;

//В C# допустимо множественное наследование ТОЛЬКО ОТ ИНТЕРФЕЙСОВ!!
//Множественное наследование реализации(т.е от двух и более классов или структур) НЕДОПУСТИМО!
//ДОПУСТИМО множественное наследование от одного и многих интерфейсов.

namespace _004_Interfaces
{
    class DerivedClass:BaseClass,IInterface1, IInterface2  //ЗНАЧЕК : ПРИМЕНИМО К КЛАССАМ - ЗНАЧЕК НАСЛЕДОВАНИЯ
                                                                     //ПРИМЕНИМО К ИНТЕРФЕЙСАМ - ЗНАЧЕК РЕАЛИЗАЦИИ
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из IInterface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из IInterface2");
        }
    }
}
