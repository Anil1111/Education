
//Пространства имен.

//Пространства имен

namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC { }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

namespace NamespaceA.NamespaceB.NamespaceC
{
    class MyClassC2
    {
        //Видно все потому, что NamespaceA.NamespaceB.NamespaceC включает в себя другие пространства имен с классами.
        //"Видим звезды, но не видим молекул"
        MyClassA myA = new MyClassA();
        MyClassB myB = new MyClassB();
        MyClassC myC = new MyClassC();
    }
}

namespace _018_Namespace_extension_continue_example_17
{
    using NamespaceA.NamespaceB.NamespaceC;
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
