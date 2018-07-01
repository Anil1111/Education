
//Пространства имен.

namespace MyNamespace
{
    class MyClass { }

    namespace MyNamespace
    {
        //Допустимо иметь во вложенных пространствах имен, одноименные типы
        class MyClass { }
    }
}

namespace _012_Namespaces_1_namespace_into_another_with_the_same_name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Но теперь нужно указывать полное квалифицированное имя.
            MyNamespace.MyClass my1 = new MyNamespace.MyClass();
            MyNamespace.MyNamespace.MyClass my2 = new MyNamespace.MyNamespace.MyClass();
        }
    }
}
