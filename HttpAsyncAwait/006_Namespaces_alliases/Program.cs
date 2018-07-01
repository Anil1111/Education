
//Пространства имен. Псевдонимы типов.

using System.Collections.Specialized;
using NamespaceA;

namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC
            {
                public void Method()
                {
                    System.Console.WriteLine("Hello world");
                }
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

namespace _006_Namespaces_alliases
{
    //Создание псевдонима MyClass, для класса MyClassC из пространства имен NamespaceA.NamespaceB.NamespaceC

    using VasyaClass = NamespaceA.NamespaceB.NamespaceC.MyClassC; //это НЕ ИМПОРТ, а создание аллиаса
    class Program
    {
        static void Main(string[] args)
        {
            VasyaClass my = new VasyaClass();
            my.Method();
            System.Console.WriteLine(my.GetType()); //prints  NamespaceA.NamespaceB.NamespaceC.MyClassC;

            //Delay
            System.Console.ReadKey(); 
        }
    }
}
