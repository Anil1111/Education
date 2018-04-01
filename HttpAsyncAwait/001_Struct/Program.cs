using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Struct
{   //Все локальные пременные, которые мы создаем в методах - ХРАНЯТСЯ В СТЕКЕ!
    //Если это переменная ссылочного типа, то она (т.е ссылка на обьект на куче) будет хранится в СТЕКЕ
    //а сам обьект - будет хранится на куче!

    struct MyStruct
    {
        public int field;
        //public int field2 = 55;  нельзя инициализировать НЕ статические поля сразу.
        public static int field3=555;  //Статические - можно.
        public static int field4;
    }
    class Program
    {
        static void Main(string[] args) //ключевое слово new - обозначает создать экземпляр НА КУЧЕ. тут такого слова нету.
        {
            //Создание экземпляра структорного типа БЕЗ ВЫЗОВА КОНСТРУКТОРА.
            MyStruct instance;

            instance.field = 33; //Закоментировать

            //Попытка вывода значения неинициализированного поля приведет к ошибке
            Console.WriteLine(instance.field);

            MyStruct.field4 = 555;// и это закоментируй - ошибки не будет.
            Console.WriteLine(MyStruct.field4);
            //Delay
            Console.ReadKey();
        }
    }
}
