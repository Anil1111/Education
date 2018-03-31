using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Inner
{
    //В C# все называюется Nested, не зависимо от того, статический он или нет.
    //Inner класс
    public class OuterForInner //внешний класс
    {
        public void anOuterForInnerMethod()
        {
            Console.WriteLine("anOuterForInnerMethod");
        }

        public class Inner // в языке Java вложенные НЕстатические классы называются Inner
        {
            public void anInnerMethod()
            {
                Console.WriteLine("anInnerMethod");
            }
        }
    }
    //Nested класс
    public class OuterForNested
    {
        public void anOuterForNestedMethod()
        {
            Console.WriteLine("anOuterForNestedMethod");
        }

        public static class NestedStatic // в языке Java вложенные НЕстатические классы называются Nested
        {
            public static void anNestedStaticMethod()
            {
                Console.WriteLine("anNestedStaticMethod");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
