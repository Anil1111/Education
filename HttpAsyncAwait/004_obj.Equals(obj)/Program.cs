using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_obj.Equals_obj_
{
    class Program
    {
        //Equals - помимо значения сравниваемых элеменов - ПО УМОЛЧАНИЮ смотрит ещё и на hashCod`ы 
        static void Main(string[] args)
        {
            Object obj1 = new Object();
            Object obj2 = new Object();

            Console.WriteLine(obj1.Equals(obj2)); //false - потому, что отличаются HashCod`ы. ИМЕННО ПО ЭТОМУ, переопределяя Equals нужно переопределять GetHashCode
            // Equals() проходит в 2 этапа. Сразу сравниваются hashcod`ы и если они разные, то автоматически считается, что элементы НЕ РАВНЫ. 
            // Если hashcod`ы равны - то тогда делаются основные проверки. Это своего родо оптимазация - не тратить время на основные
            // проверки, если hashcod`ы не равны.
            obj1 = obj2; //теперь на obj2 сcылается и obj1 и obj2

            Console.WriteLine(obj1.Equals(obj2));

            //Delay
            Console.ReadKey();
        }
    }
}
