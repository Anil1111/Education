using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Abstraction
{   //Абстрактный класс
    abstract class AbstractClass
    {
        public abstract void Method();  //это то же самое, что и   public virtual void Method() {} 
        //может быть public и protected. нельзя потом в производном классе изменить этот модификатор!!
    }
    //Конкретный класс
    class ConcreteClass : AbstractClass
    {
        public override void Method()   //мы реализуем(переопределяем) виртуальный метод из базового класса
        {
            Console.WriteLine("Implementation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Сделать ConcreteClass instance = new ConcreteClass(); - это неправильно с точки зрения  мышления
            //Абстракция должна сформировать собирательное понятие, а конкретика(ConcreteClass) все равно потом должна 
            //представится абстракцией.
            AbstractClass instance = new ConcreteClass(); //Тут желательно приводить к базовому абстрактному типу
            instance.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
