using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Dynamic_example
{
    class MyClass
    {
        private dynamic field;

        public MyClass(dynamic argument)
        {
            this.field = argument;
        }
        //Динамические свойства.
        public dynamic MyAuthoProperty { get; set; }

        public dynamic Field
        {
            get => field;
            set => value = field;
        }

        //Динамические агрументы и возвращаемые значение в методах.
        public dynamic Method(dynamic argument)
        {
            return argument;
        }
        //Динамические массивы и индексаторы.
        dynamic[] array = new dynamic[3];

        public dynamic this[dynamic index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
