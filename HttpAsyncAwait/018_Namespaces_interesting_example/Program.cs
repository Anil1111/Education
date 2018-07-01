
// Пространства имен.

namespace NamespaceA
{
    namespace NamespaceB
    {

        namespace NamespaceC
        {
            class MyClassC
            {
                MyClassA myA = new MyClassA();
                MyClassB myB = new MyClassB();
                MyClassB2 myB2 = new MyClassB2(); // этот класс тоже видно т.к мы его добавили ниже
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

namespace NamespaceA.NamespaceB
{
    class MyClassB2 { }
}

namespace _018_Namespaces_interesting_example
{
    using NamespaceA.NamespaceB;
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
