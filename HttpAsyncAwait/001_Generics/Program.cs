using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Generics
{
    //ОБОБЩЕНИЯ ПОМАГАТЮТ ИЗБАВИТСЯ ОТ BOXING И UNBOXING.
    //Перегрузки обобщенных методов отличаются КОЛИЧЕСТВОМ ПАРАМЕТРОВ ТИПА, А НЕ ИХ ИМЕНАМИ.
    //Оказывается, параметры быают не только у методов. Параметры бывают и у классов. Когда мы создаем класс с параметрами - то 
    //такой класс будет называться параметризированным кассом.
    //На 12й строке создаем класс с именем MyClass, параметризированный одним УКАЗАТЕЛЕМ МЕСТА ЗАПОЛНЕНИЯ ТИПОМ - TRoman
    class MyClass<TRoman>
    {
        public TRoman Field; //такой тип называют открытым потому, что он открыт к помещению в него какого-то натсоящего типа.

        public void Method()
        {
            Console.WriteLine(Field.GetType());//GetType возвращает ссылку на построенный им экзампляр класса Type, 
            //который содержит информацию о типе того члена(в данном случае Field), на котором был вызван метод GetType
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Классы в своих параметрах принимают не какие-то значения. Они принимают ТИПЫ!
            //Создаем экземпляр класса MyClass и в качестве параметра типа передаем int = закрываем класс int`ом
            //Создаем экземпляр класса MyClass и закрываем его int`ом
            //Инстранцируем класс MyClass и закрываем его типом int
            MyClass<int> instance = new MyClass<int>();
            instance.Method();
            //Создаем экземпляр класса MyClass и в качестве параметра типа передаем long = закрываем класс long`ом
            MyClass<long> instance2 = new MyClass<long>();
            instance2.Method();
            //Создаем экземпляр класса MyClass и в качестве параметра типа передаем string = закрываем класс string`ом
            MyClass<string> instance3 = new MyClass<string>();
            instance3.Field = "123"; //тут нужно проинициаизировать, иначе будет NullReferanceException
            instance3.Method();

            //Delay
            Console.ReadKey();
        }
        //В С++ - ШАБЛОН, В C# - Generic
        //В С++ используются шаблоны - т.е если я делаю так: MyClass<int> instance то создается(КОПИПАСТИТСЯ) класс, 
        //невидимо для програмиста- вот так:
        //class MyClass
        //{
        //    public int Field;

        //    public void Method()
        //    {
        //        Console.WriteLine(Field.GetType());//GetType возвращает ссылку на построенный им экзампляр класса Type, 
        //    }
        //}
        
        //В С# не так - тут шабон ЖИВЕТ НА УРОВНЕ ИСПОЛНЯЕМОГО ФАЙЛА - не копипастятся шаблоны как в C++
    }
}
