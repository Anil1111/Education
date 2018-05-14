using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Generics_ContrVariant
{
    //Только ИНТЕРФЕЙСЫ и ДЕЛЕГАТЫ в C# поддерживают технику ковариантности и контрвариантности обобщений
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<in T>//СЛОВО in И БУДЕТ ОТПРЕДЕЛЯТЬ НАСТОЯЩУЮ КОНТРвариантность В ОБОБЩЕНИЯХ.
    {
        T Figure { set; } //свойство ТОЛЬКО ДЛЯ ЗАПИСИ и СЛОВО in
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;

        public Container(T arg)
        {
            this.figure = arg;
        }

        public T Figure
        {
            set => figure = value;
        }

        public override string ToString() //т.к все наследуется от object, то в любом классе можем переопределить метод ToString
        {
            return figure.GetType().ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //КОНСТвариантность - downcast параметра типа!
            Shape shape = new Circle(); //UPCAST т.к downcast невозможен без предварительного upcast`a
            //Container приводится к базовому типу IContainer, а Shape - необорот к производному Circle DOWNCAST
            IContainer<Circle> container = new Container<Shape>(shape);//главное, чтобы тут было все ок. если Container закрыт Shape`ом, то нужно и передавать Shape
            Console.WriteLine(container.ToString());
            
            //Delay
            Console.ReadKey();
        }
    }
}
