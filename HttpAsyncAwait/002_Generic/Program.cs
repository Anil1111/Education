using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Generic
{
    public class MyClass<TYPE1, TYPE2>
    {
        //Fields
        private TYPE1 field1;
        private TYPE2 field2;
        //Constructor
        public MyClass(TYPE1 arg1, TYPE2 arg2)
        {
            this.field1 = arg1;
            this.field2 = arg2;
        }
        //Properties
        public TYPE1 Field1
        {
            get => this.field1;
            set => this.field1 = value;
        }

        public TYPE2 Field2
        {
            get => this.field2;
            set => this.field2 = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int, int> instance = new MyClass<int, int>(1, 2);
            Console.WriteLine(instance.Field1 + instance.Field2);

            MyClass<int, string> instance2 = new MyClass<int, string>(5, "Snow");
            Console.WriteLine(instance2.Field1 + instance2.Field2);

            MyClass<string, string> instance3 = new MyClass<string, string>("Let it", " Snow");
            Console.WriteLine(instance3.Field1 + instance3.Field2);

            //Dealy
            Console.ReadKey();
        }
    }
}
