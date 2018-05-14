using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_GenericDelegate
{
    class Animal { }

    class Cat:Animal { }
    class Program
    {
        delegate T MyDelegate<out T>(); //out - для возвращаемого значения

        static Cat CatCreator()
        {
            return  new Cat();
        }
        static void Main(string[] args)
        {
            MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);
            MyDelegate<Animal> delegateAnimal = delegateCat; //КОвариантность - UPCAST параметра типа (Cat к Animal)

            Animal animal = delegateAnimal.Invoke();
            Console.WriteLine(animal.GetType().Name);

            //Delay
            Console.ReadKey();
        }
    }
}
