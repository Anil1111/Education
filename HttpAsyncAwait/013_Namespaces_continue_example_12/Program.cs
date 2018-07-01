
//Пространства имен

namespace MyNamespace
{
    class MyClass { }

    namespace MyNamespace
    {
        //Допустимо иметь во вложенных пространствах имен, одноименные стереотипы.

        class MyClass { }
    }
}

namespace _013_Namespaces_continue_example_12
{
    //Даже не смотря на то, я заиспортил MyNamespace и MyNamespace.MyNamespace, то все равно 
    //прийдется указать полное квалифицированное имя MyClass(чтобы указать класс и какого namespace я хочу использовать)
    using MyNamespace;
    using MyNamespace.MyNamespace;

    class Program
    {
        static void Main(string[] args)
        {
            //Если несколько импортируемых пространств имен содаржат одноименные стереотипы,
            //то инстанцированые требует полной квалификации имени стереотипа.

            //MyClass my = new MyClass(); //Ошибка

            MyNamespace.MyClass my1 = new MyNamespace.MyClass();
            MyNamespace.MyNamespace.MyClass my2 = new MyNamespace.MyNamespace.MyClass();
        }
    }
}
