using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_AdditionalTask2
{
    interface ICarPark<T> where T: new()
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void DeleteAll();
    }
}
