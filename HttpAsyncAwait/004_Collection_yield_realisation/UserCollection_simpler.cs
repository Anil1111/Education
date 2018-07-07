using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Collection_yield_realisation
{
    public class UserCollection_simpler<T> //не используем наследование от интерфейсов, а вместо этого будем использовать yield
    {
        private T[] elements;
        private int position = -1;

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public UserCollection_simpler()
        {
            this.elements = new T[4];
            this.position = -1;
        }

        public void Reset() => position = -1;

        public IEnumerator GetEnumerator()
        {
            Enumerator enumerator = new Enumerator(); //конфигурируем экземпляр класса нулем.
            enumerator.collection_instance = (UserCollection_simpler<T>) this; //вот тут мы предоставляем классу Enumerator информацию о коллекции.
            return enumerator;
        }

        //Nested Class - сгенерируемый by yield
        private sealed class Enumerator : IEnumerator<object>, IDisposable
        {
            private object current;
            public UserCollection_simpler<T> collection_instance; //ВОТ ПОЛЕ, ГДЕ хранится все информация о нашей коллекции.

            public bool MoveNext()
            {
                if (this.collection_instance.position < (this.collection_instance.elements.Length - 1))
                {
                    this.collection_instance.position++;
                    this.current = this.collection_instance.elements[this.collection_instance.position];
                    return true;
                }

                return false;
            }

            public void Dispose()
            {
                this.collection_instance.Reset();
            }

            void IEnumerator.Reset()
            {
               // this.collection_instance.position = -1;
            }

            object IEnumerator<object>.Current => this.current;

            object IEnumerator.Current => this.current;
        }
    }
}
