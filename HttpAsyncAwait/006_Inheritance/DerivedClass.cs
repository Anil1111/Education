using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Inheritance
{
    class  DerivedClass : BaseClass
    {
        //Замещение  метода базового класса. Resharper просит ввести слово new, чтобы было понятней. 
        public new void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
