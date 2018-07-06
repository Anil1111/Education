using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Collection
{
    //Класс элементов, которые входят в состав коллекции.
    public class Element
    {
        public int FieldA { get; set; }
        public int FieldB { get; set; }

        public Element(int fieldA, int fieldB)
        {
            this.FieldA = fieldA;
            this.FieldB = fieldB;
        }
    }
}
