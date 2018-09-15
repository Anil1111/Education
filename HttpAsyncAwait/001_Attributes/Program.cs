using System;
using _001_Attributes.Attributes;

namespace _001_Attributes
{
    //Так, как AllowMultiple = false , то я не могу этот же аттрибут использовать 2 раз для одного и того же класса
    //[My("1/31/2008", Number = 1)] 
    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)] //можно не использовать суффикс Attribute
        public static void Method()
        {
            Console.WriteLine("MyClass.Mеthod()\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass.Method();

            //Содать аттрибут - это только полдела. Нужно им ещё воспользоваться!
            //Для этого нужна рефлексия.

            //Delay
            Console.ReadKey();
        }
    }
}
