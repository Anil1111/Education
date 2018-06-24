using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0012_Dynamic_compiler_does_not_check
{
    class MyClass
    {

    }
    class Program
    {
        static dynamic FactoryMethod() => new MyClass();
        static void Main(string[] args)
        {
            dynamic instance = FactoryMethod() as dynamic; //к динамическому типу допустимо приводиться
            var a = instance is dynamic;

            if (false)
            {
                instance.Method(7);                     //Вызов метода, которого нет
                instance.field = instance.Property;     //Получиние и установка значений полей и свойств, которых нет
                instance["one"] = instance[2];          //Получение и установка значений через индексаторы, которых нет
                dynamic variable = instance + 3;        //Вызов перегрузки операторов, которых нет
                variable = instance(5, 7);              //Вызов делегатов, которых нет
            }
            
            //Delay
            Console.ReadKey();
            //Зачем такое нужно? А вдруг я поменяю тип во время аыполнения программы и эти действия будут возможны.
        }
    }
}
