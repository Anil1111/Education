using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ConstraintNaked
{
    class Program
    {
        //Аргумент типа,  предоставленный в качестве Т, должен совпадать с аргументом, предсотавленный в качестве U, или быть 
        //производным от него. ЭТО И НАЗЫВАЕТСЯ ограничением типа "Naked".
        class MyClass<T, R, U> where T : U
        {

        }
        static void Main(string[] args)
        {
            MyClass<int , object, int> my1 = new MyClass<int, object, int>();
            MyClass<string, Object, string> my2 = new MyClass<string, object, string>();
            MyClass<string,object,object> my3 = new MyClass<string, object, object>();

            //MyClass<string,object,int> my4 = new MyClass<string, object, int>(); ОШИБКА!
        }
    }
}
