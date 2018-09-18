using System;

namespace _002_DestructorStruc
{
    //Ограничения деструкторов
    struct MyStruct
    {
        //В структрах недопустимо создавать деструкторы. Предлагается либо изменить MyStruct на class, либо воспользоваться паттерном IDisposable(смотри конец урока)
        //~MyStruct()
        //{

        //}
    }

    class MyClass
    {
        //Деструкторы не могут иметь аргументов
        //~MyClass(int a)
        //{

        //}

        //Деструкторы не могут быть статическими, виртуальными, абстрактными и т.д
        //static ~MyClass()
        //{

        //}

        //Деструкторы не могут иметь модификаторов доступа
        //public ~MyClass()
        //{

        //}
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
