using System;
using System.Collections;

namespace CollectionInterfaces
{
    class Collection : IEnumerable
    {
        private int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            private int[] array;
            public Iterator(Collection collection)
            {
                this.array = collection.array; //видим даже приватный массив т.к Iterator nested класс в классе Collection
            }

            private int currentPosition = -1;
            public bool MoveNext()
            {
                if (currentPosition < array.Length - 1)
                {
                    currentPosition++;
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                currentPosition = -1;
            }

            public object Current => array[currentPosition];
        }
    }
}
