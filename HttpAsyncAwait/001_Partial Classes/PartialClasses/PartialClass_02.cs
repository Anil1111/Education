using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Partial_Classes.PartialClasses
{
   public  partial class PartialClass
    {
        public void MethodFromSecondPart()
        {
            Console.WriteLine("Method from 2nd part of partial class");
        }
    }
}
