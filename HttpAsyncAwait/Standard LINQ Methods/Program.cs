using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_LINQ_Methods
{
    class Program
    {
        static IEnumerable<long> GetFibonacciNumber()
        {
            long current = 1, previous = 0;
            while (true)
            {
                yield return current;
                var temp = previous;
                previous = current;
                current += temp;
            }
        }
        static void Main(string[] args)
        {
            //The standard LINQ methods are implemented as extension methods to the IEnumerable interface. They reside in the System.Linq.Enumerable class.

            //These methods are divided into three basic flavors: 
            //those that return a sequence in the original order, 
            //those that return a sequence in a different order, 
            //and those that return a singleton value.


            //Sequence in Original Order
            //Some methods return a new sequence where all or a portion of the original sequence is included, in its original order.
            //These methods do not require materialization of the sequence to begin returning items.
            //These methods include: Append, AsEnumerable, Cast, Concat, Empty, Except, OfType, Prepend, Range, Repeat, Select, SelectMany, Skip, SkipWhile, Take, TakeWhile, Where, and Zip.

            //Sequence in New Order
            //Some methods return a new sequence where all or a portion of the original sequence is included, but in a different order.
            //While execution is still deferred until you begin consuming the sequence, this can be deceptive.
            //In order to return the initial item in the sequence, these methods must first evaluate(and materialize) either a portion or all of the sequence. 
            //These methods include: Distinct, GroupBy, GroupJoin, Intersect, Join, OrderBy, OrderByDescending, Reverse, ThenBy, ThenByDescending, and Union.

            //Singleton
            //The singleton methods force immediate materialization of at least a portion of the sequence.
            //These methods include: Aggregate, All, Any, Average, Contains, Count, DefaultIfEmpty, ElementAt, ElementAtOrDefault, First,
            //FirstOrDefault, Last, LastOrDefault, LongCount, Max, Min, SequenceEqual, Single, SingleOrDefault, Sum, ToArray, ToDictionary, ToList, and ToLookup

            //Avoiding Materialization
            var collection = GetFibonacciNumber().DefaultIfEmpty(); //PeekableEnumerable.NullIfEmpty хз что это.
                                                                    //Bottom line, lack of ingenuity is probably the most common cause of premature materialization. 
                                                                    //That said, there are a few times when materialization is necessary and unavoidable.
                                                                    //Simply take some extra time to consider your circumstances, before simply slapping a ToList onto your sequence.
        }
    }
}
