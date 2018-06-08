using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable enumrl = UserCollection.Power();
            foreach (string element in enumrl)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(new string('-', 30));

            //------------------------------
            //Так работает foreach
            IEnumerable enumerable = UserCollection.Power();
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                String element = enumerator.Current as String;
                Console.WriteLine(element);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
