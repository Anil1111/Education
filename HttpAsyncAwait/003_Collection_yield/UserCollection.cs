using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Collection_yield
{
    public class UserCollection<T>
    {
        readonly T[] elements = new T[4];

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        private int position = -1;

        //Создаем метод Reset();

        public void Reset() => position = -1;

        //Создаем метод GetEnumerator(), используем оператор yield.
        public IEnumerator GetEnumerator()
        {
            // ---------- 1-й вариант. -------------

            //while (true)
            //{
            //    if (position < elements.Length - 1)
            //    {
            //        position++;
            //        yield return elements[position];
            //    }
            //    else
            //    {
            //        Reset();
            //        yield break; //возвращает пустой итератор (а у этого итератора метод MoveNext будет возврашать false)
            //        //широко применяется при работе с БД
            //    }
            //}

            // ---------- 2-й вариант. -------------

            //foreach (var element in elements)
            //{
            //    yield return element;
            //}

            // ---------- 3-й вариант. -------------

            return elements.GetEnumerator();
            //На массиве вызываем метод GetEnumerator.
            //Наведи на метод и нажми F12. Попадешь в класс Array. 
            //Посмотри какие интерфейсы этот класс реализует.
        }
    }
}
