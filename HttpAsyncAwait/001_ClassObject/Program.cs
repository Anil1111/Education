using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ClassObject
{
    //все классы неявно наследуются от object
    class MyClassA //: Object //полное имя
    {

    }

    class MyClassB //: object //алиас
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //HashCode и ссылка на обьект в переменной, например в instanceA - это РАЗНЫЕ ВЕЩИ!
            Object instanceA = new MyClassA();
            object instanceB = new MyClassB();
            //instanceA. - 4 метода: Equals(object), GetHashCode(), GetType(), ToString().
            //Object. - 2 статических метода: Equals(object,object) и ReferenceEquals(object, object)


            //Object browser => mscorlib[..] => System => Object

            // ~Object() - диструктор- это специальный метод, который учавствует в финализации объекта. 
            // Вызывается автоматически перед тем, как Garbage Collector будет удалять обьект из кучи.

            // Equals(object) - виртуальный - ПРАВИЛО: если переопределяется Equals(object), то нужно и переопределить GetHashCode()
            // Equals(object,object) - статический
            // GetHashCode() -виртуальный- возвращает hash code обьекта - т.е некий номер паспорта - 

            // GetType() - возращает ссылку на экземпляр класса Type, который нам выдаст всю информацию
            // о типе того обьекта(экземпляра), на котором и был вызван этот метод.

            // MemberwiseClone() - граф.наследование клонирует ГЛУБОКО, а все ассоциации клонирует ПОВЕРХНОСТНО!
            // Смесь ГЛУБОКОГО и ПОВЕРХНОСТНОГО клонирования называется ЧАСТИЧНЫМ(неполным) клонированием.
            // Object() - конструктор
            // ReferenceEquals(object, object) - статический - сверяет ССЫЛКИ НА обьекты(адреса обьектов на куче).
            // Может быть так, что HashCod`ы совпадают и значение в обьектах одинаковое, НО ССЫЛКИ НА ТО ОБЬЕКТЫ РАЗНЫЕ!
            // ToString() - виртуальный

            //ДВА СТАТИЧЕСИХ: каждый из них имеет 2 аргумента - Equals(object,object) и ReferenceEquals(object, object)
            //Три виртуальных: Equals(object), GetHashCode(), ToString()
            //Delay
            Console.ReadKey();
        }
    }
}
