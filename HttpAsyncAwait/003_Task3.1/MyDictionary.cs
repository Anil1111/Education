using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3._1
{
    class MyDictionary<TKey, TValue> : IMyDictionarycs<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int length;
        public int Length => length;

        public MyDictionary(int n)
        {
            this.key = new TKey[n];
            this.value = new TValue[n];
            this.length = n;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + " - " + value[index];
                }

                return "Попытка обращения за пределы массива.";
            }
        }

        public void Add(int i, TKey k, TValue v)
        {
            this.key[i] = k;
            this.value[i] = v;
        }
    }
}
