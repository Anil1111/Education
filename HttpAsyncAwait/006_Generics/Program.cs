using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<T>
    {
        T Figure { get; set; } //асбтрактное свойство
    }

    public class Container<T> : IContainer<T>
    {
        public T Figure { get; set; }

        public Container(T arg)
        {
            this.Figure = arg;
        }
    }
    class Program
    {
        //Что такое КОВАРИАНТНОСТЬ В GENERIC? Upcast параметра типа.
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            //тут Container приводится к IContainer , а Shape остается Shape
            IContainer<Shape> instrance = new Container<Shape>(circle); //свойство  public T Figure { get; set; } будет типа Shape(ПРОИСХОДИТ НЕЯВНЫЙ UPCAST АРГУМЕНТА!)
            Console.WriteLine(instrance.Figure.ToString());

            //Delay
            Console.ReadKey();
        }
    }
}
