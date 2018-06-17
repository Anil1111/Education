using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Shallow_Cloning
{
    //Клонирование ассициаций происходит поверхностно.
    class A { public int a = 1; }
    class B { public int b = 2; }
    class C { public B B = new B(); }

    class X 
    {
        public A A = new A(); //ассоциация!
        public C C = new C(); //ассоциация!
    }
    class Program : X //т.к мы наследуемся от X, у нас есть все поля, но они связанны с помощью АССОЦИАЦИИ, а она копируется ПОВЕРХНОСТНО
    {
        static void Main(string[] args)
        {
            Program original = new Program();
            Console.WriteLine("Оригинал :" + original.A.a + " " + original.C.B.b);

            //Клонирование объекта
            //MemberwiseClone склонирует Program, склонирует X от которого и наследуется Program. Но в X, который получился в результате клонирования
            // поля  public A A и public C C будут ссылаться НА СУЩЕВСТВУЮЩИЕ поля!Вот это и есть - поверхностное клонирование.
            //Только граф. наследования склонировался, а ассоциации не склонировались. - и вот эти обьекты теперь 'общие',
            //как буд-то статические.
            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("Клон :" + clone.A.a + " " + clone.C.B.b + "\n");

            //Проверка на глубокое клонирование
            clone.A.a = clone.C.B.b = 7;
            //Смесь ГЛУБОКОГО и ПОВЕРХНОСТНОГО клонирования называется ЧАСТИЧНЫМ(неполным) клонированием.
            Console.WriteLine("Оригинал :" + original.A.a + " " + original.C.B.b);
            Console.WriteLine("Клон :" + clone.A.a + " " + clone.C.B.b);

            //Delay
            Console.ReadKey();
        }
    }
}
