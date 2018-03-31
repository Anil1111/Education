using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance = new NotStaticClass(); //как только мы коснулись работы класса, который
            instance.NotStaticMethod(); //содержит статический конструктор - этот конструктор БУДЕТ ВЫЗВАН В ПЕРВУЮ ОЧЕРЕДЬ!
                                        //Сначала отрабатывает статический - а потом не статический конструктор
            NotStaticClass.Field = 2;
            Console.WriteLine(NotStaticClass.Field); //если выполнить только это , то НЕ статический конструктор 
                                    //и вызываться не будет т.к мы не строим экземпляр класса.

            NotStaticClass.Method();
            NotStaticClass.Method(3);

            //Delay
            Console.ReadKey();
        }
    }
}
