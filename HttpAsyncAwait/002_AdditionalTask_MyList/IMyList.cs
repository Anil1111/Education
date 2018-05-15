using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_AdditionalTask_MyList
{
    public interface IMyList<T>
    {
        void Add(T a);
        T this [int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}
