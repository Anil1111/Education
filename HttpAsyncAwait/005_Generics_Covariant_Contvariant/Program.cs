using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Generics_Covariant_Contvariant
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
        static void Main(string[] args)
        {
            //ковариантности и контрвариантности тут нет.
            Circle circle = new Circle();
            IContainer<Circle> instrance = new Container<Circle>(circle);
            Console.WriteLine(instrance.Figure.ToString());

            //Delay
            Console.ReadKey();
        }
    }
}
