using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ICollection_Generic
{
    class UserCollection<T> : ICollection<T>
    {
        // ICollection<T> наследуется от IEnumerable<T>, IEnumerable, т.е + ещё метод GetEnumerator<T>, GetEnumerator

        // int Count { get; } //вернет количество элементов сколько хранится в нашей коллекции

        // bool IsReadOnly { get; } // возвращает bool, является ли коллекция IsReadOnly 
        //(нельзя ничего записать, а можно только читать, но нужно самому добавлять в методы Add, Remove проверку на ReadOnly)

        // void Add(T item); //Повзоляет добавлять элемент в коллекцию И ЕСЛИ ЕСТЬ МЕТОД Add - то МОЖНО ИСПОЛЬЗОВАТЬ БЛОК ИНИЦИАЛИЗАТОРА

        // void Clear();  //Очистить коллекцию

        // bool Contains(T item);  //Проверяет, есть ли определенный элемент в коллекции

        // void CopyTo(T[] array, int arrayIndex); //копирует элементы из нашей коллекции в коллекцию Array array начиная с конкретного индека Array

        // bool Remove(T item); //Удаляет элемент из коллеции(работает по первому совпадению), возвращает true - если элемент был успешно удален.

        T[] elements = new T[0];

        public int Count => elements.Length; //Получает числе элементов, содержащихся в коллекции
        public bool IsReadOnly { get; } = false; // Получает значение, указывающее, доступна ли ICollection<T> только для чтения. Нужно пользоваться перед вызовом метода Add().

        //Добавяет элемент
        public void Add(T item)
        {
            var newArray = new T[elements.Length + 1];   //Создание нового массива(на 1 больше старого)
            elements.CopyTo(newArray, 0);                //Копирование старого массива в новый.
            newArray[newArray.Length - 1] = item;        //Помещение нового значения в конец сторого массива.
            elements = newArray;                         //Замена старого массива но новый. (Старый массив съедает Garbage Collector). 
                                                         //Он видит, что старый массив лежит и на него нет нигде ссылки.
        }

        //Удаляет все элементы из коллекции
        public void Clear()
        {
            elements = new T[0];
        }

        //Определяет, сожерит ли коллекция указанное значение
        public bool Contains(T item)
        {
            foreach (var element in elements)
            {
                if (element.Equals(item))
                    return true;
            }

            return false;

            //Or we can use LINQ :)
            //return elements.Contains(item);
        }

        //Копирует элементы коллекции в Array, начиная с конкретного индекса Array
        public void CopyTo(T[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }

        //Удаляет первое вхождение указанного объекта из коллекции
        public bool Remove(T item)
        {
            var isRemoved = this.elements.ToList().Remove(item);
            this.elements.ToArray();

            return isRemoved;
        }

        //Возвращает перечислитель, выполняющий перебор элементов в коллекции.
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        //Возвращает перечислитель, который выполняет итерацию по элементам коллекции
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
    }
}
