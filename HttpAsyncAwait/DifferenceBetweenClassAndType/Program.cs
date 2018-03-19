using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenClassAndType
{//Что определяет тип? набор методов!(интерфейс взаимодействия)
    interface IGoEater
    {
        void Go();
        void Eat();
    }

    interface ISecurity:IGoEater
    {
        void Guard();
    }
    class Dog: ISecurity
    {
        public void Go()
        {
            Console.WriteLine("Dog step!");
        }
        public void Eat()
        {
            Console.WriteLine("Dog style eat!");
        }

        public void Guard()
        {

        }
    }

    class Cat: IGoEater
    {
        public void Go()
        {
            Console.WriteLine("Cat step!");
        }
        public void Eat()
        {
            Console.WriteLine("Cat style eat!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IGoEater dog = new Dog();
            IGoEater cat = new Cat();
            //если ИНТЕРФЕЙСЫ СОВПАДАЮТ, ТО ОБЪЕКТЫ ЭТИХ КЛАССОВ НАЗЫВАЮТСЯ ОДНОТИПНЫМИ
            dog.Go();//Классы разные, но ИНТЕРФЕЙСЫ вздаимодействия с этими классами т.е ИМЕНА МЕТОДОВ СОВПАДАЮТ!!!
            dog.Eat();
            //т.е и dog и cat имеют методы Go и Eat, то есть  dog и cat - однотипные обьекты
            cat.Go();//Классы разные, но ИНТЕРФЕЙСЫ вздаимодействия с этими классами т.е ИМЕНА МЕТОДОВ СОВПАДАЮТ!!!
            cat.Eat();

            //
            //dog.Guard(); //теперь обьекты dog и cat не однотипные т.е я добавил метод Guard И ПРИВЕЛ dog к ISecurity!

            //класс - отностится к конструкции языка, а тип - это понятие, которые отностися к обьекту языка

            //КЛАССЫ МОГУТ БЫТЬ РАЗНЫЕ, НО ТИПЫ ЭТИХ ОБЬЕКТОВ МОГУТ БЫТЬ ОДИНАКОВЫМИ
            //И наоборот, классы могут быть одинаковые, но ТИПЫ ТО МОГУТ БЫТЬ РАЗНЫЕ ЗА СЧЕТ ПРИВЕДЕНИЯ К НУЖНОМУ ИНТЕРФЕЙСНОМУ ТИПУ
        }
    }
}
