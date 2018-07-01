
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

namespace NamespaceA.NamespaceB.NamespaceC //Просто расширяем пространствао имен NamespaceA.NamespaceB.NamespaceC
{
    class MyClassC2 { }
}

namespace _017_Namespaces_extanding_the_namespace
{
    using NamespaceA.NamespaceB.NamespaceC;

    class Program
    {
        static void Main(string[] args)
        {
            MyClassC myC = new MyClassC();
            MyClassC2 myCC = new MyClassC2();
        }
    }
}
