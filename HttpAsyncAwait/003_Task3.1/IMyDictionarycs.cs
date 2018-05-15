using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3._1
{
    public interface IMyDictionarycs<TKey,TValue>
    {
        int Length { get; }
        string this[int index] { get; }
        void Add(int i, TKey k, TValue v);
    }
}
