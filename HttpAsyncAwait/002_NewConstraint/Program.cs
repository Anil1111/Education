using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_NewConstraint
{
    class Program
    {
        //where T: new() - Аргумент типа должен иметь открытый конструктор без параметров.

        //При использовании с другими ограничениями, ОГРАНИЧЕНИЕ //where T: new() должно устанавливаться ПОСЛЕДНИМ:
        //class MyClass<T> where T : class, new () { /* ........*/ }
        class MyClass<T> where T : new()
        {
            public T instance = new T(); //ограничение НЕ работает с асбтрактными классами т.к экземпляр такого класса создать нельзя.

            public void GetValues()
            {
                Console.WriteLine(instance.ToString());
            }
        }

        public class TestClass
        {
            public int MyIntProperty { get; set; }
            public string MyStringProperty { get; set; }
            public override string ToString() //Переопределяем метод ToString из базового класса object
            {
                return string.Format("{0} - {1}", MyIntProperty, MyStringProperty);
            }
        }
        static void Main(string[] args)
        {
            var foo = new MyClass<TestClass>();
            foo.instance.MyIntProperty = 1;
            foo.instance.MyStringProperty = "Hello, Roman";
            foo.GetValues();

            //Delay
            Console.ReadKey();
        }
    }
}
