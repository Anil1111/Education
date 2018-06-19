using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some of the methods in System.Linq.Enumerable create entirely new sequences.
            //These include: Empty, Range, and Repeat.

            //Empty
            //The Empty method creates an empty sequence (with no items).
            var emptySequence = Enumerable.Empty<int>();

            //Range
            //The Range method creates a sequence containing a range of integer values.
            var rangeSequence = Enumerable.Range(1, 5);

            //Repeat
            //Repeat method creates a sequence containing repeated occurrences of a single item.
            var sequenceWithRepeat = Enumerable.Repeat("Repeat Me", 5);
        }
    }
}
