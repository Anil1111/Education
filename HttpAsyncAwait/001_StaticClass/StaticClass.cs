using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Статический класс в C#, выражает идею ПАТТЕРНА проeктирования - Signletion!
//Правила:
//1. Экземпляр статического класса нельзя создать.
//2. Static class всегда наследуется от Object - ЯВНО или НЕ ЯВНО. Попытка наследования от чего либо другого приводит
//к ошибке уровня компиляции.
//3. Static class НЕ РЕАЛИЗУЕТ ИНТЕФЕЙСЫ. Попытка наследования от интерфейса приводит к ошибке уровня компиляции.
//4. Содержит ТОЛЬКО СТАТИЧЕСКИЕ ЧЛЕНЫ(исключение:nested классы могут быть не статические). Наличие
// в СТАТИЧЕСКОМ класса НЕ статического члена приведет к ошибке уровня компиляции.
//5. Статический класс не может содержать конструкторов экземпляров(ОБЫЧНЫХ конструкторов).
//6. Статический класс ЗАКРЫТ для наследования от него. Попытка наследования от статического класса приводит к 
// ошибке уровня компиляции.
namespace _001_StaticClass
{
    //по умолчанию sealed  - но явно указывать НЕЛЬЗЯ!
    static  class StaticClass //: IFormatProvider НЕЛЬЗЯ наследоваться от интерфейса
    {                          //Наследуется неявно от object

        //Конструктор экземпляра - недопустим.
        //public StaticClass()
        //{
        //    Console.WriteLine("Constructor");
        //}

        //Статический конструктор.
        static StaticClass()
        {
            Console.WriteLine("Static constructor");
        }

        //Статический метод
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }

        //Нестатический метод - недопустим!   Cannot declare instance method in static class
        //public void NotStaticMethod() 
        //{
        //    Console.WriteLine("NotStaticMethod");
        //}
    }
}
