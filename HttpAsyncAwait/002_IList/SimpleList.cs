using System;
using System.Collections;

namespace _002_IList
{
    class SimpleList : IList //(список)
    {
        //IList наследуется от ICollection, IEnumerable т.е ещё + члены Count, SyncRoot, IsSynchronized, CopyTo, GetEnumerator

        //object this[int index] { get; set; } // индексатор, чтобы обращаться к элементам писка по индексу

        //bool IsReadOnly { get; } //возвращает bool, является ли список только для чтения

        //bool IsFixedSize { get; } // возврашает bool, является ли список фиксированного размера или нет

        //int Add(object value); //Повзоляет добавлять элемент в коллекцию

        //void Clear(); //Очистить коллекцию

        //bool Contains(object value); //Проверяет, есть ли определенный элемент в коллекции

        //int IndexOf(object value); //Возвращает индекс элемента value, в противном случае возвращает -1

        //void Insert(int index, object value); //Вставить во внутрь коллекции так, чтобы он был под инкдесом index и значинием value

        //void Remove(object value); //Удаляет элемент из коллеции(работает по первому совпадению), возвращает true - если элемент был успешно удален.

        //void RemoveAt(int index); //Удаляет элемент по индексу. Т.е просто Remove удаляет первый встретившийся элемент, то метод void RemoveAt(int index) бывает полезен

        private object[] contents = new object[8];
        private int count;

        public SimpleList()
        {
            count = 0;
        }

        #region IList Members
        /// <summary>
        /// Добавляет элемент в список IList
        /// </summary>
        /// <param name="value">Элемент, который требуется поместить в коллекцию</param>
        /// <returns>Индекса элемента, который помещен в коллецию</returns>
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

        //Удаляет все элементы с коллекции и обнуляет счетчик.
        public void Clear()
        {
            contents = new object[0];
            count = 0;
        }

        //Определяет, содержится ли указанное значение в списке IList.
        public bool Contains(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (contents[i] == value)
                    return true;
            }

            return false;
        }

        //Определяет индекса указанного элемента в списке IList
        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (contents[i] == value)
                    return i;
            }

            return -1;
        }

        //Вставляет элемент в коллекцию IList c заданним индексом.
        public void Insert(int index, object value)
        {
            if ((count + 1 <= contents.Length) && (index < Count) && (index >= 0))
            {
                count++;

                for (int i = Count - 1; i < index; i--)
                {
                    contents[i] = contents[i - 1];
                }

                contents[index] = value;
            }
        }

        //Получает значение показывающее, имеет ли список IList фиксированный размер
        public bool IsFixedSize => true;

        //Получает значение указывающее, доступна ли коллекция IList только для чтения
        public bool IsReadOnly => false;

        //Удаляет первое вхождение указанного объекта из списка IList
        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        //Удаляет элемент из списка, расположенный по указанному индексу.
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

        //Копирует элементы ICollection в Array, начиная с конкретного индекса Array
        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(contents[i], j);
                j++;
            }
        }

        //Возвращает число элементов, содержащихся в коллекции ICollection
        public int Count => count;

        //Получает значение, позволяющее определить, является ли доступ к колекции синхронизированным
        public bool IsSynchronized { get; } = false;

        //Получает оббект, который можно использовать для синхронизации доступа к ICollection
        public object SyncRoot => null;

        #endregion

        #region IEnumerable Members

        //Возвращает перечислитель, который определяет итерацию по элементпам коллекции.
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
