
//Простанства имен. Сокрытие имен стереотипов.

//В случае наличия одноименных стереотипов во вложенном и во внешнем пространствах имен,
//происходит сокрытие имени стереотипа внешнего пространства имен.
//Обращение к одноименному стереотипу внешнего пространства имен, потребует полной квалификации имени стереотипа.

namespace NamespaceA
{
    namespace NamespaceB
    {
        class MyClass { }

        class MyClassB
        {
            private MyClass my1; //вот тут вот имя namespace`a скрыто
            private NamespaceA.MyClass my2; // обращаемся к классу извне, по этому и указываем полное квалиф. имя.
            private MyClassA my3; //прямая видимость есть, то этому и указываать полное квалиф. имя не нужно.
        }
    }
    class MyClass { }
    class MyClassA { }

}

namespace _016_Namespace_in_namespace_vision
{
    using NamespaceA;
    using NamespaceA.NamespaceB;

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
