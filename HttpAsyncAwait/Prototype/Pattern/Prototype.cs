using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Pattern
{
    abstract class Prototype
    {
        private string id;
        public string Id => id;

        public Prototype(string id)
        {
            this.id = id;
        }
        //Метод клонирования
        public abstract Prototype Clone();
    }
}
