using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Delegates
{
    delegate MyDelegate Functional(MyDelegate myDelegate1, MyDelegate myDelegate2);
    delegate string MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            //Техника предположения делегата
            MyDelegate delegate1 = () => "Hello", delegate2 = () => "World";


            Functional functional = delegate (MyDelegate my1, MyDelegate my2) { return delegate () { return my1.Invoke() + my2.Invoke(); };};
            //Разбираем по полочкам: Functional functional - сразу смотрим на то, 
            //что должен принимать и возвращать метод , сообщеный с делегаом типа Functional.
            //Он принимает (MyDelegate myDelegate1, MyDelegate myDelegate2) и возвращает MyDelegate.
            //По коду можно понять, что  delegate () { return myDelegate1.Invoke() + myDelegate2.Invoke(); - это и есть  MyDelegate
            //Смотрим, подходит ли нам этот метод? ничего не принимает а возвращает string, значит подходит.

            Functional functional2 = delegate (MyDelegate my1, MyDelegate my2) { return  () => my1.Invoke() + my2.Invoke(); };

            Functional functional3 = (my1, my2) => () => my1() + my1();
            //принцип точно тот же : Functional - смотрим на то, что принимает и возвращает метод, который может быть сообщен с делегатом такого типа.
            //можно догадаться, что (my1, my2) это и есть (MyDelegate myDelegate1, MyDelegate myDelegate2).
            //Зачем писать тип аргументов 2 раза, если они уже описаны в делегате?
            //Вот то, что возвращает метод,сообщенный с делегатом : () => my1.Invoke() + my1.Invoke();
            //Смотрим, что он должен возвращать и можно понять, что  () - это ничего не принимает,  => my1.Invoke() + my1.Invoke(); - это возвращает string.

            Console.WriteLine(functional.Invoke(delegate1,delegate2).Invoke());
            //Точно то же самое
            //Console.WriteLine(functional(delegate1, delegate2)());

            //Delay
            Console.ReadKey();
        }
    }
}
