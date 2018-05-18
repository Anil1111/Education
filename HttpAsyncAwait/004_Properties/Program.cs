using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Properties
{//Классы. (Использовангие свойств, для доступа к закрытым полям.)
    class MyClass
    {
        string field = default(string);

        public string Field
        {
            private set
            {
                if (value == "fool")
                    Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку.");
                else
                {
                    field = value;
                }
            }
            get
            {
                if (field == null)
                    return "В поле field отсутствуют данные";
                else if (field == "hello world")
                    return field.ToUpper() + "!";
                else
                    return field;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            //instance.Field = "fool";
            Console.WriteLine(instance.Field);

            Console.WriteLine(new string('-', 30));

            //nstance.Field = "hello world";
            Console.WriteLine(instance.Field);

            //Delay
            Console.ReadKey();
        }
    }
}
