using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_IList
{
    //List - список. Список - это коллекция, у каждого элемента которой есть определнный порядок(есть индекс у каждого члена).
    class SimplestList : IList
    {
        private readonly object[] contents = new object[8];
        private int count;

        public SimplestList() => count = 0;

        #region IList Members
        //Добавляет новый элемент в коллекцию
        public int Add(object value)
        {
            if (count < contents.Length)
            {
                contents[count] = value;
                count++;

                return (count - 1);
            }

            return -1;
        }

        //Проверяет, есть ли элемент в коллекции
        public bool Contains(object value)
        {
            return IndexOf(value) != -1;
        }

        public void Clear()
        {
            count = 0;
        }

        //Определяет индекс заданого элемента в списке IList
        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (contents[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, object value)
        {
            if ((count + 1 <= contents.Length) && (index < Count) && (index >= 0))
            {
                count++;

                for (int i = Count - 1; i > index; i--)
                {
                    contents[i] = contents[i - 1];
                }

                contents[index] = value;
            }
        }

        //Получает значение, указывающее, доступна ли коллекция IList только для чтения.
        public bool IsReadOnly => false;

        //Получает значение, указывающее, доступна ли коллекция IList только для чтения.
        public bool IsFixedSize => true;

        //Удаляет первое вхождение указанного объекта из списка IList
        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        //Удаляет элемент из IList, расположенный по указанному индексу
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    contents[i] = contents[i + 1];
                }

                count--;
            }
        }

        public object this[int index]
        {
            get => contents[index];
            set => contents[index] = value;
        }



        #endregion

        #region ICollection Members

        //Копирует элементы ICollection в Array, начиная с конкретного индекса Array.
        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(contents[i], j);
                j++;
            }
        }

        //Возвращает число элементов в коллекции
        public int Count => count;

        //Получает значение, позволяющее определить, является ли доступ к коллекции синхронизированным
        public bool IsSynchronized => false;

        //Получает объект, который можно использовать для синхронизации доступа к ICollection.
        public object SyncRoot => null;
        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return contents[i];
            }
        }
        #endregion

        public void PrintContents()
        {
            Console.WriteLine($"Список имеет емкость {count} и в настоящее время имеет {Count} элементов.");
            Console.Write("Список содержит:");

            for (int i = 0; i < Count; i++)
            {
                Console.Write($" {contents[i]}");
            }

            Console.WriteLine("\n" + new string('-', 55));
        }
    }
}
