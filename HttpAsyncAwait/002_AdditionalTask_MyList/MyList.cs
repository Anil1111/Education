using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_AdditionalTask_MyList
{
    public class MyList<T> : IMyList<T> //ГЛАВНОЕ -ЗАПОМНИТЬ! ЭТО ТАК УДОБНО - ИСПОЛЬЗОВАТЬ ИНТЕРФЕЙСЫ!
    {
        private T[] array;

        public MyList()
        {
            this.array = new T[0];
        }

        public void Add(T a)
        {
            var tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = a;
            array = tempArray; //здесь текущий массив останется без ссылки и будет уничтожен Garbage Collector`ом
        }

        public T this[int index] => array[index];

        public int Count => array.Length;
        public void Clear()
        {
            var clearArray = new T[0];
            this.array = clearArray;
        }

        public bool Contains(T item)
        {
            return array.Any(x => x.Equals(item));
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka+= String.Concat(array[i]," ");
            }

            return $"Размерность массива {this.Count}. Элементы массива {stroka}";
        }

    }
}
