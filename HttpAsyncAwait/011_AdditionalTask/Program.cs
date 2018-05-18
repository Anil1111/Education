using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _011_AdditionalTask
{
    class Program
    {
        class MyClass
        {
            public int MyIntProperty { get; set; }
            public string MyStringProperty { get; set; }

            public override string ToString()
            {
                return MyIntProperty + " " + MyStringProperty;
            }
        }
        static void Main(string[] args)
        {
            var collection = new ArrayList(); //все значения, которые мы передаем будут заапкащены к object
            collection.Add(1);
            collection.Add(0.67);
            collection.Add("1");
            collection.Add('a');
            collection.Add(new MyClass() { MyIntProperty = 10, MyStringProperty = "Hello" }); //выведется 10 Hello

            //collection[4]. тут не будет свойств, которые есть в классе MyClass т.к все приводится к object 
            //если мы захотим получить функциональность всех элементов обратно, то нужно знать, к какому типу DownCast`ить каждый из элементов массива.

            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
