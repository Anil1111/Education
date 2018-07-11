using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Pattern
{
    class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList elements = new ArrayList(); //хранилище данных
        private ConcreteIterator iterator; //будет перечислять коллекцию

        public override Iterator CreateIterator()
        {
            this.iterator = new ConcreteIterator(this);

            return iterator;
        }

        public int Count => elements.Count;

        public override object this[int index]
        {
            get => elements[index];
            set => elements.Insert(index, value);
        }
    }
}
