using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Yield
{
    //оператор yield - оператор ГЕНЕРАЦИИ БЛОКА ИТЕРАТОРА.
    //Т.е оператор yield занимается тем, что генерит специальный класс, который выступает в роли итератора для коллекции
    //(смотри пример 003_CollectionInterfaces)

    //Каждый новый вызов yield return добавляет элемент в коллекцию т.е array[i] становиться новым элементом коллекции внутри класса.
    class Collection : IEnumerable
    {
        int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}
