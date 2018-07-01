
//Пространства имен.

namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClass
            {
                public MyClass()
                {
                    System.Console.WriteLine(this.GetType().Name);
                }
            }
        }
    }
}


namespace _005_Namespaces
{
    using NamespaceA.NamespaceB.NamespaceC; //указываем ПОЛНЫЙ ПУТЬ ВЛОЖЕНОСТИ
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
        }
    }
}
