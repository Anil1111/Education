using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{
    public class DerivedClass:BaseClass
    {
        public DerivedClass()
        {
            //изменяем все доступные поля, унаследованные от BaseClass
            publicField = "DerivedClass.PublicField";
            protectedField = "DerivedClass.ProtectedField";
            //privateField  - нету доступа
        }
    }
}
