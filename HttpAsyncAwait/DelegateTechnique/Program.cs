using System;
//Техника делегирования.
namespace DelegateTechnique
{
    class A //сапожник
    {
        public string DoSomething(string shoes)
        {
            //Console.WriteLine("Отремонтируй ботинки");
            return shoes + "|||||||||";
        }
    }

    class B //девушка
    {
        public string DoSomething(string shoes)
        {
            A a = new A(); //девушка создвет сапожника и говорит ему то же самое , что и я сказал ей.
            return a.DoSomething(shoes);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            string renovatredShoes = b.DoSomething("shoes");

            //Delay
            Console.ReadKey();
        }
    }
}
