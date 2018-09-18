using System;

namespace _007_DestructorObject
{
    class MyClass : Object
    {
        // INFO: 
        // В базовом классе Object имеется свой диструктор,
        // но он НЕ ВЫЗЫВАЕТСЯ для объектов производного класса.
        // В ПРОИЗВОДНЫХ КЛАССАХ, ТРЕБУЕТСЯ СОЗДАВАТЬ СОБСТВЕННЫЙ ДЕСТРУКТОР.

        // Наведи на Object и нажми F12
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
        }
    }
}
