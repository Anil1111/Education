using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Collection_yield_realisation
{
    //Коллекция, которая может получится после автоматической генерации 
    //програмного кода при использовании оператора yield.
    public class UserCollection<T> //не используем наследование от интерфейсов, а вместо этого будем использовать yield
    {
        private T[] elements;
        private int position = -1;

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public UserCollection()
        {
            this.elements = new T[4];
            this.position = -1;
        }

        public void Reset() => position = -1;

        //public IEnumerator GetEnumerator()
        //{
            
        //}

        private sealed class Enumerator : IEnumerator<object>, IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public object Current { get; }

            object IEnumerator.Current => Current;
        }
    }
}
