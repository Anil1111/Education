using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_ListGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Коллекция - некое обьектно ориентированное представление массива.
            //Чем отличается коллекция от массива? Во-первых больше функциональности, удобство обращения и т.д.
            ArrayList arrayList = new ArrayList(); //коллекции, которые могут в себе хравнить разнотипные элементы.(например int и string)

            //Boxing
            arrayList.Add(1); //метод Add принимает тип object
            arrayList.Add((object)2);

            //Unboxing
            int i1 = (int)arrayList[0]; //внутри коллекции есть индексатор
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(new string('-', 50));
            }

            List<int> list = new List<int>();
            
            //Упаковки нет
            list.Add(3);
            list.Add(4);

            //Распаковки нет
            int i3 = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
