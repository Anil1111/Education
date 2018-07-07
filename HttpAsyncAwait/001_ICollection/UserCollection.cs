using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ICollection
{
    //ICollection - определяет размер, перечислители и методы синхронизации для всех нестандартных коллекций.
    class UserCollection : ICollection
    {
        //ICollection наследуется от IEnumarable, т.е + ещё метод GetEnumerator

        // int Count { get; }  // кол-во элементов в коллекции

        // object SyncRoot { get; } // объект синхронизации доступа к разделяемому ресурсу(коллекции)

        // bool IsSynchronized { get; } // можем ли мы использовать объект синхронизации доступа к разделяемому ресурсу(коллекции)

        // void CopyTo(Array array, int index);  //копирует элементы из нашей коллекции в коллекцию Array array начиная с конкретного индека Array

        public int Count => elements.Length; //возвращает число элементов, содержащихся в коллекции ICollection
        public object SyncRoot => new object(); //эстафетная палочка. Получает объект, который можно использовать для синхронизации доступа к ICollection
        public bool IsSynchronized => true; //Получает значение, позволяющее определять, является ли доступ к коллекции ICollection синхронизирован.

        private readonly object[] elements = { 1, 2, 3, 4 };

        //Копирует элементы ICollection в Array, начиная с конкретного индекса Array
        public void CopyTo(Array array, int userArrayIndex)
        {
            var arr = array as object[];
            if(arr == null)
                throw new Exception("Expecting arry to be object[]");

            for (int i = 0; i < array.Length; i++)
            {
                arr[userArrayIndex++] = elements[i];
            }
        }

        //Возвращает перечислитель, который выполняет итерацию по элементам колекции.
        public IEnumerator GetEnumerator() => elements.GetEnumerator();//Этот метод берем из массива. А массива в C# не сущевствует.
        //Массив - полноценная коллекция(все массивы наследуются от класса Array), у котором тоже есть много методов.
    }
}
