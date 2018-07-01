
//Пространства имен.

//Технически, допускается создание нескольких пространств имен с одним именем.
//Логически, несколько одноименных пространств имен, объединяются в одно пространство имен.


namespace MyNamespace
{
    class MyClass { }
}

namespace MyNamespace
{
    //Недопустимо иметь в одноименных пространствах имен одноименные типы
    //class MyClass { } //Ошибка
}

namespace _001_Namespaces_2_namespaces_with_the_same_name
{
    class Program
    {
        static void Main(string[] args)
        {
             MyNamespace.MyClass my = new MyNamespace.MyClass();
        }
    }
}
