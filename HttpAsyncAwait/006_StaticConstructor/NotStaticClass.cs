using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_StaticConstructor
{
    class NotStaticClass :BaseClass
    {
        // Если класс содержит статические поля, может быть предоставлен СТАТИЧЕСКИЙ
        // конструктор, который инициализиует эти поля при загрузке класса.

        private static int field;
        private int a = 2;
        //public static int Method1()
        //{
        //    return a;  //Статические МЕТОДЫ НЕ МОГУТ обращаться к НЕ СТАТИЧЕСКИМ ПОЛЯМ.
        //}
        public static int Field
        {
            get => field;
            set => field = value;
        }
        //Статический конструктор.
        //Единственное назнaчение статических конструкторов - ПРИСВАИВАТЬ ИСХОДНЫЕ ЗНАЧЕНИЯ СТАТИЧЕСКИМ ПЕРЕМЕННЫМ.

        //Есть пользовательчские конструкторы и конструкторы по умолчанию.
        //Так же есть статические и НЕ статические конструткоры. 
        //СТАТИЧЕСКИЕ КОНСТРУКТОРЫ НЕ МОГУТ БЫТЬ ПОЛЬЗОВАТЕЛЬСКИМИ!
        static NotStaticClass() // т.е класс НЕ СТАТИЧЕСКИЙ - а конструктор СТАТИЧЕСКИЙ. Он только по умолчанию(ничего не принимает)
        {                          //А почему мы не можем передать агрументы? Потому, что мы его руками не вызываем.
                                   //Аргументы нужны только тем, которым мы можем вызвать самостоятельно.
                                   //А этот конструктор вызывается сам, без нашего участия.
            Console.WriteLine("Статический конструктор - NotStaticClass()");
            field = 1;
        }

        public NotStaticClass() //строит экземпляр
        {
            Console.WriteLine("NotStaticConstructor");
        }

        //А ДОПУСТИМО ЛИ ПЕРЕГРУЖАТЬ СТАТИЧЕСКИЕ МЕТОДЫ?
        //Да, допустимо! Статические методы могут быть перегружены.
        public static void Method()
        {
            Console.WriteLine("Статический метод, нестатического класса 'NotStaticClass'");
        }
        //Статические методы могут быть перегружены
        public static void Method(int s)
        {
            Console.WriteLine("Перегруженный статический метол, нестатического класса 'NotStaticClass'"+s);
        }

        public void NotStaticMethod()
        {
            Console.WriteLine($"NotStaticMethod {Field}");
        }
    }
}
