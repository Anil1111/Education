using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Indexers
{
    class DerivedClass:BaseClass
    {
        // Конструкции языка, которые могут быть выртуальными - это методы, свойства, индексаторы и ещё одна конструкция.
        private string[] derivedArray;

        // Конструктор
        public DerivedClass()
        {
            derivedArray = new string[3];
            derivedArray[0] = "Zero";
            derivedArray[1] = "One";
            derivedArray[2] = "Two";
        }

        // Переопределенный индексатор
        public override string this[int index]
        {
            get {return string.Concat(base[index], " - ", derivedArray[index]); }
        }
    }
}
