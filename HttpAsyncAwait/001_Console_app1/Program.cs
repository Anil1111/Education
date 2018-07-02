using System;
using ClassLibraryy1; //подключили как библиотеку из проекта
using ClassLibrary2; //подключили как dll файл через browse

namespace _001_Console_app1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 instance = new Class1();
            instance.Method();

            Class2 instance2 = new Class2();
            instance2.Method();

            //Чем отличается подключание как проекта и как файла? Хз чем.
            //1. Там где проект - можно поставить тройной комментарий и тут его будет видно. Вот наведи щас на Method() из Class1,
            //но, у меня получилось так же сделать и на Class2 даже если он подключен как файл

            //Delay
            Console.ReadKey();
        }
    }
}
