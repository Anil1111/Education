using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MyClass
    {
        private int[] array = new int[] { 1, 2, 3, 4, 5 };
        private string  stringArray = "string";

        public int this[int index]
        {
            get => array[index];               //Аксессор
            set => array[index] = value;       //Мутатор
        }

        // public int this[int index]   Member with the same signature already exists
        public string this[string index]
        {
            get { return index; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance[2] = 56;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance[i]);
            }
            Console.WriteLine(instance["string"]);

            //Delay
            Console.ReadKey();
        }
    }
}
