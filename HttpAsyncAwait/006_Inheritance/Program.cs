using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //UpCast
            BaseClass newInstance = instance;
            newInstance.Method();

            //DownCast
            DerivedClass instanceDown = (DerivedClass) newInstance;
            instanceDown.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
