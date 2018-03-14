using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_1_CombineVirtulAndNotVirtual
{
    class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }

        public void NOTVIsrtualMethod()
        {
            Console.WriteLine("NOTVIsrtualMethod from BaseClass");
        }
    }
}
