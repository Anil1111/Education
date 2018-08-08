using System;
using System.Collections;

namespace _005_Hashtable
{
    //сделаем так, чтобы экземпляры класса Fish с одинаковым name вели себя как буд-то есть pool интернирования строк
    //для этого нужно всего лишь переопределить GetHashCode и Equals
    public class Fish
    {
        private readonly string name;

        public Fish(string name)
        {
            this.name = name;
        }
        //поставь breakpoint и пошагай
        public override int GetHashCode() //переопределяя GetHashCode - переопределяй и Equals
        {
            return name.GetHashCode();
        }

        //поставь breakpoint и пошагай и попробуй закоментить оба Equals`a
        public override bool Equals(object obj)
        {
            var anotherFish = obj as Fish; //если obj нельзя привести к Fish то as вернет null
            if (anotherFish == null)
            {
                return false;
            }

            return anotherFish.name == name;   //Count будет 1
            //return anotherFish.name != name; //Count будет 2

            //В общем если equals вернет false, то ещё один объект будет добавлен
            //А если true - значит объекты инаковы и тогда зачем добавлять ещё один объект в словарь?
            //return true;
        }
    }

    public class Dog
    {
        private readonly string name;

        public Dog(string name)
        {
            this.name = name;
        }
        public override int GetHashCode() //переопределяя GetHashCode - переопределяй и Equals
        {
            return name.GetHashCode();
        }

        //поставь breakpoint и пошагай и попробуй закоментировать оба Equals`a
        public override bool Equals(object obj)
        {
            var anotherFish = obj as Dog;
            if (anotherFish == null)
            {
                return false;
            }

            return anotherFish.name == name;

            //В общем если equals вернет false, то ещё один объект будет добавлен
            //А если true - значит объекты инаковы и тогда зачем добавлять ещё один объект в словарь?
            //return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var duplicates = new Hashtable();

            var key1 = new Fish("Herring");
            var key2 = new Fish("Herring");

            var key3 = new Dog("Herring");

            duplicates[key1] = "Hello";
            duplicates[key2] = "Hello2"; //заменило т.к у этих объектов ХЭШИ БЕРУТСЯ ПО name.

            duplicates[key3] = "Vasya"; // добавит даже не смоторя на то, что хэши name одинаковы!
            //вызывается метод Equals где мы делается ещё одна проверка

            Console.WriteLine(duplicates.Count); //если закоментить все Equals`ы то будет 3 объекта

            //Delay
            Console.ReadKey();
        }
    }
}
