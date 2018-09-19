using System;

//Большие объекты размещаются в БОЛЬШОЙ КУЧЕ и сразу относятся ко ВТОРОМУ поколению.
namespace _003_GCBigObjects
{
    //BigObject - ОБЕРТКА для большого объекта. Будет размещен в МАЛОЙ КУЧЕ и будет ссылатться на то, что внутри - на БОЛЬШОЙ КУЧЕ.
    public class BigObject
    {
        //Действительно большой объект. Будет размещен на БОЛЬШОЙ КУЧЕ.
        // 100 000 000 * 4Б = 400 000 000 Б = 390 625 КБ = 381 МБ
        public Array array = new int[100000000];

        public BigObject() => Console.WriteLine("Сonstructor {0}", this.GetHashCode());
        ~BigObject() => Console.WriteLine("Объект {0} удален", this.GetHashCode());
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Действительно большой объект. Будет размещен в БОЛЬШОЙ КУЧЕ (Поколение 2)
            // 100 000 000 * 4 Б = 400 000 000 Б = 390 625 КБ = 381 МБ
            Array array = new int[100000000];
            Console.WriteLine("Поколение объекта Array: {0}",GC.GetGeneration(array)); //выведется 2

            //Будет размещен на малой куче, а внутренний массив в большой куче (Поколение 2)
            BigObject @object = new BigObject();
            Console.WriteLine("Поколение объекта BigObject: {0}", GC.GetGeneration(@object)); //выведется 0
            Console.WriteLine("Поколение объекта BigObject.array: {0}", GC.GetGeneration(@object.array)); //выведется 2
            //Delay
            Console.ReadKey();
        }
    }
}
