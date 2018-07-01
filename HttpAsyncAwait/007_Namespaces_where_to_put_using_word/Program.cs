
// Пространства имен.

using NamespaceA;
using NamespaceA.NamespaceB;
using NamespaceA.NamespaceB.NamespaceC;

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

// В данно месте импорт недопустим.
// Импорт допустим или в теле namespace {...}, или перед всеми другими пространствами имен.
//using NamespaceA;
//using NamespaceA.NamespaceB;
//using NamespaceA.NamespaceB.NamespaceC;
namespace _007_Namespaces_where_to_put_using_word
{
    using NamespaceA;
    using NamespaceA.NamespaceB;
    using NamespaceA.NamespaceB.NamespaceC;
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
