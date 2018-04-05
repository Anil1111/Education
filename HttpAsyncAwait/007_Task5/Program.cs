using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Итог этого примера: если классы предназначенны для того, чтобы хранить ДЕЙСТВИЯ(методы)
// то структуры больше предназначены для того, чтобы хранить ДАННЫЕ(т.к они не будут меняться снаружи если передать их в метод)
//т.к структуры передаются в метод ПО ЗНАЧЕНИЮ, а классы - передаются ПО ССЫЛКЕ!
namespace _007_Task5
{
    public class MyClass
    {
        public string change;
    }
    public struct MyStruct
    {
        public string change;
    }
    class Program
    {
        //static void ClassTaker(MyClass myClass)
        //{
        //    myClass.change = "changed";
        //}
        //static void StructTaker(MyStruct myStruct)
        //{
        //    myStruct.change = "changed";
        //}
        //static void Main(string[] args)
        //{
        //    MyClass insClass = new MyClass();
        //    insClass.change = "not changed";

        //    MyStruct insStr;
        //    insStr.change = "not changed";
        //    //Основное отличие структуры от класса в том, что они передаются ПО ЗНАЧЕНИЮ, а не по ссылке.
        //    ClassTaker(insClass);//если мы передаем экземпляр класса в метод, то он передается по ссылке (как ref)
        //    StructTaker(insStr); //если мы передем экземпляр структуры в метод, то он передвется ПО ЗНАЧЕНИЮ.
        //                         //т.е передается КОПИЯ этого экземпляра и то, что мы меняем внутри метода, будет только
        //                         // внутри метода и там и останется(если мы конечно не будем возращать ничего).
        //    Console.WriteLine(insClass.change);
        //    Console.WriteLine(insStr.change);

        //    //Delay
        //    Console.ReadLine();
        //}

        //Щас я сделал, чтобы экземпляр структуры передавался ПО ССЫЛКЕ( добавил ref)
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StructTaker(ref MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
        static void Main(string[] args)
        {
            MyClass insClass = new MyClass();
            insClass.change = "not changed";

            MyStruct insStr;
            insStr.change = "not changed";
            //Основное отличие структуры от класса в том, что они передаются ПО ЗНАЧЕНИЮ, а не по ссылке.
            ClassTaker(insClass);//если мы передаем экземпляр класса в метод, то он передается по ссылке (как ref)
            StructTaker(ref insStr); //если мы передем экземпляр структуры в метод, то он передвется ПО ЗНАЧЕНИЮ.
            //т.е передается КОПИЯ этого экземпляра и то, что мы меняем внутри метода, будет только
            // внутри метода и там и останется(если мы конечно не будем возращать ничего).
            Console.WriteLine(insClass.change);
            Console.WriteLine(insStr.change);

            //Delay
            Console.ReadLine();
        }
    }
}
