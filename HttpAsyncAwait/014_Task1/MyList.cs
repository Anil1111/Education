using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Task1
{
    class MyList<T>
    {
        private T[] array;
        private int position = -1;

        public MyList()
        {
            this.array = new T[0];
        }
        public IEnumerator<T> GetEnumerator()// мы не наследовались от IEnumerator и IEnumerable. В методе GetEnumerator
        {//мы возвращаем коллекцию с типом IEnumerator<T> - т.е перечислитель. А MoveNext, Reset, Current генерируются yield`ом!
            while (true) //мы вернули уже готовый перечислитель со сгенерированными методами!
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    ResetValue();
                    yield break;
                }
            }
        }

        public void ResetValue()
        {
            this.position = -1;
        }

        public int Length => array.Length;

        public T this[int index]
        {
            get
            {
                if (array.Length - 1 >= index)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Попытка доступа за пределы массива");
                    return default(T);
                }
            }
            set
            {
                if (array.Length - 1 >= index)
                {
                    array[index] = value;
                }
                else
                {
                    Console.WriteLine("Попытка доступа за пределы массива");
                }
            }
        }

        public void Add(T element)
        {
            T[] arrayHelper = new T[array.Length + 1];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    arrayHelper[i] = array[i];
            //}
            array.CopyTo(arrayHelper,0); //это то же самое

            arrayHelper[array.Length] = element;
            array = arrayHelper;
        }
    }
}
