using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Generics_Bad_Example
{
    //Плохой пример, так делать не рекомендуется!
    public class MyClass<T>
    {
        public T Add(T a, T b)
        {
            if (typeof(T) == typeof(int))
                return (T)(object)((int)(object)a + (int)(object)b);
            if (typeof(T) == typeof(double))
                return (T)(object)((double)(object)a + (double)(object)b);

            return (T)(object)0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> instance = new MyClass<int>();
            var sum = instance.Add(2, 5);

            Console.WriteLine(sum);
            //Delay
            Console.ReadKey();
        }
    }
}
