using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    // Экземпляры этого класса будет содержать коллекция UserCollection
    public class Element
    {
        private string name;
        private int field1;
        private int field2;

        public Element(string name, int field1, int field2)
        {
            this.name = name;
            this.field1 = field1;
            this.field2 = field2;
        }

        public string Name { get => name; set => name = value; }
        public int Field1 { get => field1; set => field1 = value; }
        public int Field2 { get => field2; set => field2 = value; }

    }
}
