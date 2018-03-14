using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{
    class SecondDerivedClass:DerivedClass
    {
        public SecondDerivedClass()
        {
            //изменяем все доступные поля, унаследованные от DerivedClass
            publicField = "SecondDerivedClass.PublicField";
            protectedField = "SecondDerivedClass.ProtectedField";
        }
    }
}
