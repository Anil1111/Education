using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ICollection
{
    class Collection : ICollection
    {
        private int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        object root = new object(); //для синхронизации
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(this.array[i], i + index);
            }
        }

        public int Count => array.Length;
        public object SyncRoot => root;
        public bool IsSynchronized => true;
    }
}
