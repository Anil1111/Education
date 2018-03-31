using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Constructors1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1 Вариант. (Вызывается только Статический конструктор.)
            //NotStaticClass.StaticMethod();

            //2 Вариант. (Вызывается и статический и не статический конструкторы)
            new NotStaticClass().NotStaticMethod(); //несмотря на то, что вызывался только
                                           //НЕ статический конструктор, СТАТИЧЕСКИЙ конструктор вызвался автоматически
                                           //Потому, что он ЕСТЬ и вызвался ПЕРВЫМ!

            //Итог: только мы касаемся нашего класса, в котором есть СТАТИЧЕСКИЙ конструктор,
            //то этот статический конструктор отработает В ЛЮБОМ СЛУЧАЕ, САМ, ПЕРВЫМ!

            //Delay
            Console.ReadKey();
        }
    }
}
