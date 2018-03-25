using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedInstance = new DerivedClass();
            BaseClass baseInstance = derivedInstance;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(baseInstance[i]);  // Не смотря на приведение к базовому типу 
            }                                        // У нас сработал индексатор из Derived Class'a т.к
                                                     // Первая форма принудательного полиморфизма берет верх над второй.

            //Delay
            Console.ReadKey();
        }
    }
}
