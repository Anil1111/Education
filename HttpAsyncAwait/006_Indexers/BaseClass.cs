using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Indexers
{
    class BaseClass
    {
        private string[] baseArray;

        // Конструктор
        public BaseClass()
        {
            baseArray =new string[3];
            baseArray[0] = "Ноль";
            baseArray[1] = "Один";
            baseArray[2] = "Два";
        }

        // Виртуальный индексатор
        public virtual string this[int index] => baseArray[index];
    }
}
