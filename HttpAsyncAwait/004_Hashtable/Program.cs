using System;
using System.Collections;

namespace _004_Hashtable
{
    public class Fish
    {
        public string name;

        public Fish(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var duplicates = new Hashtable();

            var key1 = new Fish("Herring");
            var key2 = new Fish("Herring");

            //Согласно таблице ИНТЕРНИРОВАНИЯ СТРОК в памяти создается первый экземпляр класса string
            //и когда создается второй то проверяется в таблице интернирования строк, есть ли такой уже экземпляр класса string
            //и если такой есть, то ещё один экземпляр класса string НЕ СОЗДАЕТСЯ, место этого копируется адрес уже существующего.

            //!!!ВАЖНО: pool интернирования строк - одно из важных выражений паттерна FlyWeight
            var key3 = "123";
            var key4 = "123";

            duplicates[key1] = "Hello";
            duplicates[key2] = "Hello2"; //добавило т.к у этих объектов РАЗНЫЕ ХЭШИ

            duplicates[key3] = "456";
            duplicates[key4] = "456!!!!!"; //А тут идет подмена т.к строковые типы работают по определнным правилам.

            //2 объекта так как они имют разные хэш-коды.
            Console.WriteLine(duplicates.Count);
            
            //Delay
            Console.ReadKey();
        }
    }
}
