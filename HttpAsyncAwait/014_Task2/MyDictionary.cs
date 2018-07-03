using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Task2
{
    public class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private TKey[] keyArray = null;
        private TValue[] valueArray = null;
        private int position = -1;

        public string this[int index]
        {
            get
            {
                if (index >= 0 && this.keyArray.Length > index && this.valueArray.Length > index)
                {
                    return this.keyArray[index] + "-" + this.valueArray[index];
                }
                else
                {
                    return "The attemt to get value of the the array range";
                }
            }
        }

        public int Length
        {
            get
            {
                if (this.keyArray.Length == this.valueArray.Length)
                {
                    return this.keyArray.Length;
                }
                else
                {
                    Console.WriteLine("The key massive and value massive have different number of items.");
                    return 0;
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] keyArrayHelper = new TKey[keyArray.Length + 1];
            TValue[] valueArrayHelper = new TValue[valueArray.Length + 1];
            keyArray.CopyTo(keyArrayHelper, 0);
            valueArray.CopyTo(valueArrayHelper, 0);
            keyArrayHelper[keyArray.Length] = key;
            valueArrayHelper[valueArray.Length] = value;
            this.keyArray = keyArrayHelper;
            this.valueArray = valueArrayHelper;
        }

        public MyDictionary()
        {
            this.keyArray = new TKey[0];
            this.valueArray = new TValue[0];
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<object>).GetEnumerator();
        }

        public void Dispose()// много коллекций наследуются от IDisposable и реализуют метод Dispose.
        {//В этом методе заключается логика для особождения ресурсов, ну я я решил использовать его для сброса счетчика position.
            Reset();
        }

        public bool MoveNext()
        {
            if (this.keyArray.Length - 1 > position && this.valueArray.Length - 1 > position)
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

        public object Current => this.keyArray[position] + "-" + this.valueArray[position];

        object IEnumerator.Current => Current;
    }
}
