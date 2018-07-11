using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Pattern
{
    class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate aggregate;
        private int current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First() => aggregate[0];

        public override object Next()
        {
            object element = null;

            if (current < aggregate.Count - 1)
            {
                element = aggregate[++current];
            }

            return element;
        }

        public override bool IsDone() => current >= aggregate.Count - 1;
        public override object CurrentItem() => aggregate[current];
    }
}
