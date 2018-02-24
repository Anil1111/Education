using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Properties
{//Классы.
    //Использование методов доступа к закрытым полям.
    class MyClass
    {
        private string field = null;

        public void SetField(string value) //Метод-мутатор - mutator-(setter)
        {
            if (value == "fool")
                field = null; 
            else
                field = value;
        }

        public string GetField()          //Метод-аксессор - accessor (getter)
        {
            return field;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello World");     //Метод-мутатор

            string @string = instance.GetField(); //Метод-аксессор

            Console.WriteLine(@string);

            //Delay
            Console.ReadKey();
        }
    }
}
