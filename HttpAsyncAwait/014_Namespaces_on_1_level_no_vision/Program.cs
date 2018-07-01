
//Пространства имен.

//Два пространства имен одного уровня вложенности, не предоставляют доступа друг-другу, к своим стереотипам, без импорта.


namespace MyNamespace
{
    namespace NamespaceA
    {
        class MyClassA
        {
            //MyClassB myA = new MyClassB(); //Без импорта - будет ошибка
        }
    }

    namespace NamespaceB
    {
        class MyClassB
        {
            //MyClassA myB = new MyClassA(); //Без импорта - будет ошибка
        }
    }

}

namespace _014_Namespaces_on_1_level_no_vision
{
    using MyNamespace.NamespaceA;
    using MyNamespace.NamespaceB;

    class Program
    {
        static void Main(string[] args)
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
        }
    }
}
