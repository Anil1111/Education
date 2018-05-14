using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Generics_ContrVariant
{
    class Animal { }
    class Cat : Animal { }
    class Program
    {
        delegate void MyDelegate<in T>(T a); //in - для аргумента

        public static void CatUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }
        static void Main(string[] args)
        {
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatUser);
            MyDelegate<Cat> delegateCat = delegateAnimal;

            delegateAnimal(new Animal());
            delegateCat(new Cat());

            //delegateCat(new Animal()); //невозможно т.к это будет DOWNCAST без UPCAST`а

            //Delay
            Console.ReadKey();
        }
    }
}
