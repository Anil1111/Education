using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Equals_obj1__obj2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj1 = new Object();
            Object obj2 = new Object();
            //Если переопределить экземплярный Equals то и статичский тоже поменятся т.к он внутри себя использует экземплярный!
            Console.WriteLine(Equals(obj1, obj2)); // статический метод Equals(obj1,obj2) ИСПОЛЬЗУЕТ ОБЫСНЫЙ МЕТОД Equals и тоже смотрит на hashCod`ы - по этому и false
            //Если переопределить экземплярный Equals то и статичский тоже поменятся!
            obj1 = obj2;
            Console.WriteLine(obj1.GetHashCode() + "         " + obj2.GetHashCode()); // а хэши то ОДИНАКОВЫ т.к в перменных хранится ССЫЛКА НА ОДИН И ТОТ ЖЕ ОБЪЕКТ
            Console.WriteLine(Object.Equals(obj1, obj2)); //true

            //Delay
            Console.ReadKey();
        }
    }
}
