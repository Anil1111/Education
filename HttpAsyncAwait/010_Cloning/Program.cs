using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Cloning
{
    //клонирование называют прототипированием. Есть паттерн Prototype. Prototype нашел свое применение в интерфейсе IClonable
    //Клонирование бывает ПОВЕРХНОСТНОЕ, ГЛУБОКОЕ. Метод MemberwiseClone делает и то и то , по этому говорят, что он выполняет НЕПОЛНОЕ клонирование.
    class MyBaseClass
    {
        public static string CompanyName = "Microsoft";
        public int age;
        public string name;
    }
    class MyDerivedClass : MyBaseClass
    {
        static void Main(string[] args)
        {
            MyDerivedClass original = new MyDerivedClass();
            original.age = 42;
            original.name = "Alex";

            Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);

            //Глубокое Клонирование.
            MyDerivedClass clone = original.MemberwiseClone() as MyDerivedClass;
            Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName+"\n");

            //Так выглядит поверхностное клонирование:
            MyDerivedClass clone1 = original; //т.е просто создали новую переменную и запихнули в него ссылку на тот же обьект.

            //Проверка на глубокое клонирование - меняем клон и если оригинал не поменяется, значит клон - отдельный обьект!
            clone.age = 23;
            clone.name = "Konstantin";
            MyBaseClass.CompanyName = "CyberBionic Systematics";

            Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);
            Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName);
            
            //Delay
            Console.ReadKey();
        }
    }
}
