using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{//Static - поля, свойства, события, конструкторы, классы.
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance1 = new NotStaticClass(1);
            NotStaticClass instance2 = new NotStaticClass(2);

            instance1.Method();
            instance2.Method();
            //На класса-обьекте NotStaticClass, обращаемся к статическому полю 0 field
            NotStaticClass.field = 1;

            instance1.Method();
            instance2.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
