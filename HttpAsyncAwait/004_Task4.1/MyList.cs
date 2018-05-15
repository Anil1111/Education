using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task4._1
{
    public class MyList<T>
    {
        private readonly T[] array;
        private readonly int length;

        public MyList(int n)
        {
            this.array = new T[n];
            this.length = array.Length;
        }

        public int Length => length;
        public T this[int index] => array[index];

        public void Add(int i, T value)
        {
            this.array[i] = value;
        }
    }
}
