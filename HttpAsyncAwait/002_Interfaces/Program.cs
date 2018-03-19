using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IInterface1 instance1 = new DerivedClasscs();
            IInterface2 instance2 = new DerivedClasscs();

            instance1.Method1();    //блягодаря тому, что мы привелись к базовому типу, методы, которых нет в определенном интерфейсе - скрыты от него! 
            //instance1.Method2();  //метод Method2() скрыт от интерфейса IInterface1

            instance2.Method2();
            //instance2.Method1();  //метод Method1() скрыт от интерфейса IInterface2

            DerivedClasscs instance3 = new DerivedClasscs();
            instance3.Method1();
            instance3.Method2();

            //Delay
            Console.ReadKey();
        }
    }
}
