using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Constructors1
{
    class NotStaticClass
    {
        //Статический конструктор вызывается в любом случае, как при обращании
        //к статическому члену, так и при создании экземпляра класса.
        static NotStaticClass()
        {
            Console.WriteLine("Статический конструктор");
        }
        //Конструктор ЭКЗЕМПЛЯРА(делает экземпляр класса, а не обьект), вызывается 
        //только при создании экземпляра.
        public NotStaticClass()
        {
            Console.WriteLine("Не статический конструктор.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        public void NotStaticMethod()
        {
            Console.WriteLine("NotStaticMethod");
        }
    }
}
