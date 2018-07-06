using System;
using System.Collections;

namespace _000_Collection
{
    //Создание простой пользовательской коллекции(составного объекта)
    public class UserCollection : IEnumerable, IEnumerator //(Наследуемся от интерфейсов, а уже потом уже их реализуем)
    {
        readonly Element[] elements = new Element[4];

        public Element this[int index]
        {
            get => this.elements[index];
            set => this.elements[index] = value;
        }

        private int position = -1;// -1 потому, что сначала работает метод MoveNext и делает position++
                                  //, а уже потом мы испольуем position в Current

        //Реализуем интерфейс IEnumerator
        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            //Попробуй закомментировать строку ниже и выполнится.
            ((IEnumerator)this).Reset(); //foreach не вызывает Reset, по этому его можно засунуть сюда или в Dispose(смотри примеры дальше).
            return false;
        }

        void IEnumerator.Reset()
        {
            this.position = -1;
        }

        public object Current => elements[position];

        //Реализуем интерфейс IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
