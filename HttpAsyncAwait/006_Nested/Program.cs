using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nested classes
//Статические классы могут в себе содержать нестатические Nested классы.
namespace _006_Nested
{
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Статический конструктор MyClass");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Статический метод класса MyClass");
        }

        public class Nested    //Статические классы могут в себе содержать нестатические Nested классы.
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Метод Nested класса.");
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
