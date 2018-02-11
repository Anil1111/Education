using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Methods1
{
    class Program
    {//Перегрузка
     //Перегруженные методы могут отличаться ТИПОМ или/и КОЛИЧЕСТВОМ АГРУМЕНТОВ 
     //а так же ref и out параметрами

        static void Function()                 //1-я перегрузка
        {
            Console.WriteLine("Hello!");
        }
        static void Function(string s)         //2-я перегрузка
        {
            Console.WriteLine("Hello" + s);  //Можно так же оставить просто Hello и не выводить фактический аргумент.
        }
        static void Function(int i)            //3-я перегрузка
        {
            Console.WriteLine(i);
        }
        static  void Function(double d)        //4-я перегрузка
        {
            Console.WriteLine(d);
        }
        static void Function(string s, int i)  //5-я перегрузка
        {
            Console.WriteLine(s + i);          //Очередность параметров, которые принимает метод отличается т.к что можем перегрузить!
        }
        static void Function(int i , string s)  //6-я перегрузка
        {
            Console.WriteLine(i + s);
        }
        static void Function(ref int i,string s)//7-я перегрузка
        {
            Console.WriteLine(i + s);
        }
        //Перегруженные методы не могут отличаться только возвращаемыми значениями!
        //static string Function(string s)
        //{
        //    Console.WriteLine(s);
        //}
        //Перегруженные методы не могут отличаться друг от друга параметрами ref и out!
        //т.е если уже есть метод , который имеет параметр с ref, то этот метод нельзя
        //перегрузить просто поменяв ref на out!
        //static void Function(out int i, string a)
        //{
        //    i = 5;
        //    Console.WriteLine(i + s);
        //}
        static void Main(string[] args)
        {
            Function();
            Function("A");
            Function(1);
            Function(3.14); 
            Function("B", 2);
            Function(3, "C");
            //Function(i:2,s:"a");

            int variable = 5;
            Function(ref variable, "D");

            //Delay
            Console.ReadKey();
        }
    }
}
