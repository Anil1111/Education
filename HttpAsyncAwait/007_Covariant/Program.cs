using System;

namespace _007_Covariant
{
    class Program
    {
        //Ковариантность - некий UpCast КАЖДОГО элемента массива. ПРИВОДИМ НЕЯВНО
        //Контрвариантность - некий DownCast КАЖДОГО элемента массива. ПРИВОДИМ ЯВНО

        //Массивы элементов ссылочных типо КОВАРИАНТНЫ, но не контрвариантные.
        //Массивы элементов структурных типо не ковариантные, но не контрвариантные.
        //ЕСЛИ И КОВАРИАНТНЫ И КОНТРВАРИАНТНЫ ТО ПРИНЯТО НАЗЫВАТЬ ИНВАРИАНТНЫ

        interface IAnimal
        {
            void Voice();
        }

        public class Dog : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Voice");
            }

            public void Jump()
            {
                Console.WriteLine("Jump");
            }
        }
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }
            Console.WriteLine(new string('-',30));

            IAnimal[] animals = dogs;//Ковариантность Т.Е НЕЯНЫЙ UPCAST
            for (int i = 0; i < dogs.Length; i++)
            {
                animals[i].Voice();
                //animals[i].Jump();
            }
            Console.WriteLine(new string('-', 30));

            dogs = (Dog[]) animals; //Не является Контрвариантностью. Т.Е ЯНЫЙ DOWNCAST
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            //Delay
            Console.ReadKey();
        }
    }
}
