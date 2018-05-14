using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Generics
{
    //Частичные классы и методы.
    //Частичные методы не могут иметь out параметрыю.
    //МОГУТ ЛИ PARTIAL CLASS`Ы БЫТЬ GENERIC`АМИ? - МОГУТ!
    //МОГУТ ЛИ PARTIAL METHOD`Ы БЫТЬ GENERIC`АМИ? - МОГУТ!
    public partial class MyClass<T>
    {
        partial void PartialMethod<T>(T a, ref T b);
    }

    public partial class MyClass<T>
    {
        partial void PartialMethod<T>(T a, ref T b)
        {
            b = default(T);
            Console.WriteLine($"{a}, {b}");
        }

        public void Proxy(T a, ref T b)
        {
            PartialMethod(a, ref b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> instance = new MyClass<int>();
        }
    }
}
