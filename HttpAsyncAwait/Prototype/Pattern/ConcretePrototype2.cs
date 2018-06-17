using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Pattern
{
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }

        public override Prototype Clone()
        {
            // Глубокое клонирование
            return new ConcretePrototype2(this.Id); //Id унаследовалось из базового класса
        }
    }
}
