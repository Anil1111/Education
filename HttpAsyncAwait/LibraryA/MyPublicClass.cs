using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ключевое слово internal является модификатором доступа для типов и членов типов.
//Внутренние (internal) типы или члены доступны только внутри этой сборки.
namespace LibraryA
{
    public class MyPublicClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod");
        }

        //internal - Доступ к типу или члену возможен из любго кода в этой сборке, но не из другой сборки.
        internal void InternalMethod()
        {
            Console.WriteLine("InternalMethod");
        }

        //internal protected - Доступ к типу или члену возможен из любого кода в этой сборке, или из производного класса в другой сборке.
        protected internal void InternalProtectedMethod()
        {
            Console.WriteLine("InternalProtectedMethod");
        }
    }
}
