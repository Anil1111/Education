using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nested classes
//НЕстатические классы могут в себе содержать статические Nested классы.
namespace _007_Nested
{
    public class MyClass
    {
        public static class Nested //НЕстатические классы могут в себе содержать статические Nested классы.
        {
            public static void StaticMethodFromNested() 
            {
                Console.WriteLine("Статический метод Nested класса.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested.StaticMethodFromNested();

            //Delay
            Console.ReadKey();
        }
    }
}
