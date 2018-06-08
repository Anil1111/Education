using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    //Коллекция- набор однотипных(в большинстве случаев) елементов. Если элементы разнотипные - то коллекция ГЕТЕРОГЕННАЯ (ArrayList)
    //https://ru.wikipedia.org/wiki/%D0%9A%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D1%8F_(%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5)
    //Банк - много обслуживающих механизмов - итераторов(просто СЧИТАЮТ деньги). Пример итератора - банкомат.
    //Паттерн Итератор - показывет как правильно создавать пользовательские коллекции.
    class Program
    {
        //foreach НЕ БУДЕТ работать без IEnumerable и IEnumerator
        static void Main(string[] args)
        {
            //Все массивы - это коллекции
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; //
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--");
            foreach (var item in array) //тут выведется 2й массив потому, что метод MoveNext(корорый создается автоматически)
            {//вмещает Reset. а так, как я сам реализовал метод MoveNext, то для UserCollection 2 foreach`a и не работали т.к в MoveNext не было Reset(); 
                Console.WriteLine(item);
            }

            var myCollection = new UserCollection();
            //используем foreach, для обращения к каждому обьекту Element внутри массива myCollection.
            foreach (Element element in myCollection) // тут element - это ПЕРЕМЕННАЯ ИТЕРАЦИИ. в LINQ - перемены диапазона.
            {//из коллекции myCollection мы поочередно извлекаем элементы и помещаем их в ПЕРЕМЕННУЮ итерации - element 
                Console.WriteLine($"Name {element.Name} Field1: {element.Field1} Field2 {element.Field2}");
            }
            //myCollection.Reset(); //Убрать для проверки. Цикл foreach не вызываем сам метод Reset();
            //его нужно запихнуть в метод MoveNext();

            Console.WriteLine(new string('-', 30) + "\n");

            foreach (Element element in myCollection)
            {
                Console.WriteLine($"Name {element.Name} Field1: {element.Field1} Field2 {element.Field2}");
            }
            Console.WriteLine(new string('-', 30) + "\n");

            //-----------------------------------------------------------------------------
            //Так работает foreach
            UserCollection myElementsCollection = new UserCollection();

            //Приведения к IEnumerable и к IEnumerator ОЧЕНЬ ВАЖНЫЕ потому, что:
            //нам никто не запрещает наследоваться от классов в которых есть уже готовые MoveNext(), Reset(), Current. А нам нужно методы
            //именно из IEnumerable и к IEnumerator а не из какого-то левого класса с непонятно какой реализацией. А когда мы приводимся
            //к интерфейсу - мы знаем, что там будут видны те методы, которые мы и реализовали из этих интерфейсов и реализовали правильно!

            //foreach - приводит коллекцию к интерфейсному типу IEnumerable. //На экземпляре не видим private методов интерфейсов!
            IEnumerable enumerable = myElementsCollection as IEnumerable; //приводимся к IEnumerable чтобы получить метод GetEnumerator

            //foreach - приводит коллекцию к интерфейсному типу вызывая метод - GetEnumarator();
            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext()) //'связка с массивом', где наши данные находятся зашита в MoveNext() и Current
            {//перемещаем курсор на шаг вперед  (с -1 на 0) и т.д
                Element element = enumerator.Current as Element;
                Console.WriteLine($"Name {element.Name} Field1: {element.Field1} Field2 {element.Field2}");
            }

            enumerator.Reset();

            //Delay
            Console.ReadKey();
        }
    }
}
