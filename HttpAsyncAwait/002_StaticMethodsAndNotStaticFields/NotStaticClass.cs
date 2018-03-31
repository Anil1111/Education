using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В статических методах нельзя обращаться к нестатическим полям.
namespace _002_StaticMethodsAndNotStaticFields
{
    class NotStaticClass
    {
        private int id;
        public static int field;

        public NotStaticClass(int id)
        {
            this.id = id;
        }

        public static void Method()
        {
          //  Console.WriteLine($"Instance {id}.field = {field}");
            Console.WriteLine("В статических методах мы не можем обращаться к нестатическим полям.");
        }
    }
}
