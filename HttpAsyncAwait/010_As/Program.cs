using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_As
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //UpCast
            BaseClass instanceUp = instance as BaseClass; //использование as при приведении типа называют 
                                                            //безопасным приведением типов
            instanceUp.Method();

            //DownCast
            DerivedClass instanceDown = instanceUp as DerivedClass;  //использование as при приведении типа называют 
                                                                     //безопасным приведением типов
            instanceDown.Method();

            //Delay
            Console.ReadKey();

        }
    }
}
