
// Пространство имен.

// Видимость во вложенных пространствах имен, при отсутствии импорта
// "Видим звезды, но не видим молекулы". Т.е во внутрь вложжености мы НЕ видим, а изнутри наружу - видим.

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
                MyClassC myC = new MyClassC();
            }
        }

        class MyClassB
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            //MyClassC myC = new MyClassC();
        }
    }

    class MyClassA
    {
        MyClassA myA  = new MyClassA();
        //MyClassB myB = new MyClassB();
        //MyClassC myC = new MyClassC();
    }
}

namespace _008_Namespaces_vision
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
