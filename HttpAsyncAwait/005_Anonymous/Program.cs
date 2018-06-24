using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Anonymous
{
    delegate void MyDelegere(string @string);
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new
            {//                          аргумент входит в тело лямбда выраждения
                MyDel = new MyDelegere((string @string) => Console.WriteLine(@string))
            };

            instance.MyDel("Hello world");

            //Лямбда выражения - однооператорный лямбда оператор
            //Лямбда оператор - многооператорное лямбда выражение
            //Delay
            Console.ReadKey();

            //Инкапсуляция:
            //1.Сокрытие членов класса
            //2.Инкапсуляция вариаций - сокрытие частей програмных систем.
            //3.Сокрытие типов данных(var). Чем больше скрываем типы данных, тем проще програмировать.
            //Но не всегда нужно скрывать. Иногда типы данных могут помочь понять что в коде вообще просходит.
            //Нужно использовать ПРАВИЛЬНОЕ ИМЕНОВАНИЕ + ПРАВИЛЬНОЕ СОКРЫТИЕ ТИПОВ ДАННЫХ и все будет ок
        }
    }
}
