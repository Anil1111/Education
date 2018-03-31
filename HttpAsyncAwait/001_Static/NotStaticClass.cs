using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    class NotStaticClass
    {
        private int id;
        public static int field;

        public NotStaticClass(int id)
        {
            this.id = id;
        }

        public void Method()
        {
            Console.WriteLine($"Instance {id}.field = {field}");
        }
    }
}
