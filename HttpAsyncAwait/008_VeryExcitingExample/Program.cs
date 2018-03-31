using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_VeryExcitingExample
{
    class Program
    {//Статический метод в абстрактном классе.
        //Зачем он нужен? Чтобы на экземпляре вызывать методы.
        //Как получить ЭКЗЕМПЛЯР АБСТРАКТНОГО КЛАССА? С помощью фабричного
        //метода вернуть экземпляр производного класса и ПРИВЕСТИСЬ К БАЗОВОМУ ТИПУ.

        static void Main(string[] args)
        {
            AbstractClass instance = AbstractClass.CreateObject();
            instance.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
