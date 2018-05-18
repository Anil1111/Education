using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _002_AdditionalTask_MyList;

namespace _011_Dictionary
{
    class Dictionary<TKey, TValue>
    {
        private readonly MyList<TKey> key;
        private readonly MyList<TValue> value;

        public Dictionary()
        {
            this.key = new MyList<TKey>();
            this.value = new MyList<TValue>();
        }

        public void AddToDictionaty(TKey k, TValue v)
        {
            key.Add(k);
            value.Add(v);
        }

        public string this[int index] => key[index] + " " + value;

        public string this[TKey k]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if ((string)(object)key[i] == (string)(object)k)
                    {
                        return "По ключу " + k.ToString().ToUpper() + "найдено значение " + value[i];
                    }
                }
                return "По ключу ничего не найдено.";
            }
        }

        public int Length => key.Count;

        public override string ToString()
        {
            string stroka = string.Empty;
            for (int i = 0; i < key.Count; i++)
            {
                stroka += key[i] + " " + value[i] + "\n";
            }

            if (stroka != null) return stroka;
            return "В словаре нет значений!";
        }
    }
}
