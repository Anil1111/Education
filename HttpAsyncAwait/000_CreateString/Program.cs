using System;

namespace _000_CreateString
{
    //Класс String - это полноценна коллекция(составной объект) т.к наследуется от IEnumerable<char>
    //и эта коллеция символов имеет свои итераторы(переборщики)
    class Program
    {
        static void Main(string[] args)
        {
            //"Hello"
            System.String s = "Hello";
            Console.WriteLine(s);
            Console.WriteLine(s.GetHashCode()); //HashCode - как номер паспорта

            //---------------------
            //Immutable types - типы, которые невозможно изменить. Если мы пытаемся изменить, то у нас создается
            //новый экзампляр этого типа, а старый экземпляр НЕ ИЗМЕНЯЕТСЯ(или погибает в случае s = s + "a";
            s = s.Insert(2, "mmmmm"); //HashCod`ы будут разные т.к string - это immutable type и вместо старой s, теперь уже новая s.
            //s[2] индексаторов нету 
            Console.WriteLine(s);
            Console.WriteLine(s.GetHashCode());

            //---------------------
            String s2 = new string('-', 20);

            //Hemmmmmlo------------------------------
            s += s2;

            //"5"
            //На экране есть ЗНАКОМЕСТА (alt + shift) и моно выделять знакоместа с рядов повыше и пониже
            string s4 = 5.ToString(); //по умолчанию ToString(); выводит полное квалифицированное имя класса.

            //"1 + 2 = 3";
            string s5 = String.Format("{0} + {1} = {2}", 1, 2, 1 + 2);


            //Delay
            Console.ReadKey();
        }
    }
}
