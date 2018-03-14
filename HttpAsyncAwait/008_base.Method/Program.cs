using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_base.Method
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            BaseClass instanceUp = new DerivedClass();  
            instanceUp.Method();         //тут тоже используется 
                                         //переопределнный в DerivedClass'е метод не смотря на UpCast.

            //Delay
            Console.ReadKey();
        }
    }
}
