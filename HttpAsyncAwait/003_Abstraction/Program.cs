using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//АБСТРАКТНЫЙ КЛАСС может НАСЛЕДОВАТЬСЯ ОТ АБСТРАКТНОГО КЛАССА.
//Реализацияф абстрактного метода из базового абстрактного класса В ПРОИЗВОДНОМ АБСТРАКТНОМ - НЕ ОБЯЗАТЕЛЬНА,
//НО ОБЯЗАТЕЛЬНА В ПЕРВОМ КОНКРЕТНОМ(он бужет реализовывать все абстрактные методы своих предков)
namespace _003_Abstraction
{
    //Абстрактный класс А
    abstract class AbstractClassA
    {
        public abstract void OperationA();
    }
    //Абстрактный класс В
    abstract class AbstractClassB:AbstractClassA
    {
        public abstract void OperationB();
    }
    //Конкретный класс 
    class ConcreteClass:AbstractClassB
    {
        public override void OperationA()
        {
            Console.WriteLine("ConcreteClass.OperationA");//Реализую метод из AbstractClassA
        }
        public override void OperationB()
        {
            Console.WriteLine("ConcreteClass.OperationB");//Реализую метод из AbstractClassB
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClassA instance = new ConcreteClass();
            instance.OperationA();
            // instance.OperationB(); //Недостепен т.к у AbstractClassA не было метода OperationB().
            //мы инкапсулировали(спрятали ненужным метод) т.к класс AbstractClassA и знать о нем не должен.

            AbstractClassB instanc2 = new ConcreteClass();
            instanc2.OperationA();
            instanc2.OperationB(); //а тут ошибки нету т.к у класса AbstractClassB есть метод OperationB().
        }
    }
}
