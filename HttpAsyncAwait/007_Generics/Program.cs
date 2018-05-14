using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Generics
{
    //КОвариантность и КОНТРвариантность работает только с 2мя конструкциями - интерфейсами и делегатами.

    public abstract class Shape { }
    public class Circle : Shape { }
    //Создаем интерфейс, параметризированный Указателем Места Заполнения Типа Т, который помечен ключевым словом out.
    //Одновременная КО И КОНТРВАРИАНТНОСТЬ назыввается ИНВАРИАНТНОСТЬЮ!
    //Пример: ПАПА и  КО И КОНТРВАРИАНТЕН К ДЕДУШКЕ.
    //Generic может быть либо КОвариантный(out) либо КОНТРвариантный(in), НО НЕ МОГУТ БЫТЬ ИНвариантныйми.
    public interface IContainer<out T>//СЛОВО out И БУДЕТ ОТПРЕДЕЛЯТЬ НАСТОЯЩУЮ КОВАРИАНТНОСТЬ В ОБОБЩЕНИЯХ.
    {
        //ПРАВИО ДЛЯ КОВАРИАНТНОСТИ - только out и только свойства для чтения!
        T Figure { get;} //асбтрактное свойство ТОЛЬКО для чтения.
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;

        public Container(T arg)
        {
            this.figure = arg;
        }

        public T Figure => figure;//реализуем свойство только для чтения.
    }
    class Program
    {
        static void Main(string[] args)
        { 
            //Что такое КОВАРИАНТНОСТЬ В GENERIC? Upcast параметра типа.
            Circle circle = new Circle();
            //КОВАРИАНТНОСТЬ ОБОБЩЕНИЙ БЛАГОДАРЯ out - если удалю out - ничего не получится.
            //Container приводится к IContainer и Circle приводится к Shape
            IContainer<Shape> container = new Container<Circle>(circle); //upcasta АРГУМЕНТА нету т.к мы передаем Circle circle и Container закрыт Circle.

            Console.WriteLine(container.Figure.ToString());

            //Delay
            Console.ReadKey();
        }
    }
}
