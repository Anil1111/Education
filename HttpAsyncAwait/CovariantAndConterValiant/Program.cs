using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovariantAndConterValiant
{
    //Массивы ссылочных типов -КОВАРИАНТНЫ И НЕ КОНТРВАРИАНТНЫ
    //Массивы структурных типо - И НЕ КОВАРИАНТНЫ И НЕ КОНТРВАРИАНТНЫ (проверить когда буду изучать структуру)
    interface IProgrammer
    {
        void Program();
    }

    class  Human:IProgrammer
    {
        public void Program()
        {
            Console.WriteLine("Programmer works");
        }

        public void Sleep()
        {
            Console.WriteLine("Programmer sleeps");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human[] people = {new Human(), new Human(), new Human()};

            for (int i = 0; i < people.Length; i++)
            {
                people[i].Program();
                people[i].Sleep();
            }

            Console.WriteLine(new string('-',30));

            IProgrammer [] programmer = people; //Неявный upcast - это КОВАРИАНТНОСТЬ массива!
            for (int i = 0; i < programmer.Length; i++)
            {
                programmer[i].Program();
                //programmer[i].Sleep();
            }

            Console.WriteLine(new string('-', 30));

            people = (Human[]) programmer; //Явный DownCast - значит этот массив НЕ КОНТРВАРИАНТНЫ
                                           //Потому, что КОНТРВАРИАНТНОСТЬ - ЭТО НЕЯВНЫЙ DownCast всех элемнтов массива - а у нас - ЯВНЫЙ!!
            for (int i = 0; i < people.Length; i++)
            {
                people[i].Program();
                people[i].Sleep();
            }

            //Delay
            Console.ReadKey();
        }
    }
}
