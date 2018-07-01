
// Пространства имен.

//Два пространства имен одного уровня вложенности, не предоставляют доступа друг-другу, к своим стереотипам, без импорта.

namespace MyNamespace
{
    namespace NamespaceA
    {
        class BaseClass
        {

        }
    }

    namespace NamespaceB
    {
        //ПРИ НАСЛЕДОВАНИИ ДОПУСТИМО ИСПОЛЬЗОВАТЬ ПОЛНОЕ КВАЛИФИЦИРОВАННОЕ ИМЯ
        class DerivedClass : NamespaceA.BaseClass
        {

        }
    }

}

namespace _015_Namespaces_2_namespaces_in_1_level_inheritance
{
    using MyNamespace.NamespaceA;
    using MyNamespace.NamespaceB;

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance1 = new BaseClass();
            DerivedClass instance2 = new DerivedClass();
        }
    }
}
