using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
    class MyCollection : IEnumerable, IEnumerator
    {
        private int[] array = { 1, 59, 43, 67, 54, 12, 33 };
        private int position=-1;
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            this.position = -1;
        }

        public object Current => array[position];
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection collection = new MyCollection();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
