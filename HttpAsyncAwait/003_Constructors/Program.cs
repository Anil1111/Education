using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass  instance = new DerivedClass(1,2);
            DerivedClass instancee = new DerivedClass();
            DerivedClass instancee2 = new DerivedClass(1);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);

            //Delay
            Console.ReadKey();
        }
    }
}
