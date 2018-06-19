using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequences_in_Original_Order
{
    class Program
    {
        public static IEnumerable<long> EnumerateFibonacci()
        {
            long current = 1, previous = 0;
            while (true)
            {
                yield return current;
                long temp = previous;
                previous = current;
                current += temp;
                //Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            //Sequences in Original Order
            //Some methods return a new sequence where all or a portion of the original sequence is included, in its original order.
            //These methods do not require materialization of the sequence to begin returning items.
            //These methods include: Append, AsEnumerable, Cast, Concat, DefaultIfEmpty, OfType, Prepend, Range, Repeat, Select, SelectMany, Skip, SkipWhile, Take, TakeWhile, Where, and Zip.

            //Append ?????
            //The Append method adds a single item to the end of the sequence.
            string[] berries = { "blackberry", "blueberry", "raspberry" };
            //var a = berries.Append("strawberry");

            //AsEnumerable
            //The AsEnumerable method is a bit beyond the scope of this article.
            //Basically, it allows a transition from the other flavor of LINQ(IQueryable) to the flavor described in this article(IEnumerable).
            //We’ll revisit this method in later articles and explain in more detail.

            IEnumerable<string> mySequence = new List<string> { "blackberry", "blueberry", "raspberry" };
            var enumerablerValue = mySequence.AsEnumerable();
            var typeOfValue = enumerablerValue.GetType();

            //Cast
            //Sometimes, it is necessary to deal with a weakly-typed sequence, especially when dealing with older.NET data types.
            //In these cases, the sequence may implement IEnumerable, but not IEnumerable<T>.
            //When all of the data types in the sequence are known to be of the same data type, the Cast method allows you to cast all of the items to that data type.
            //The Cast method casts every item in the sequence to a different data type.

            var intList = new ArrayList { 123, 456, 789 };
            IEnumerable<int> castedToInts = intList.Cast<int>();

            //If any of items are of a different data type, than what is specified, an exception will occur.
            var stringList = new ArrayList { "Alpha", 123, "Beta", "Gamma" };
            IEnumerable<int> castedToStrings = stringList.Cast<int>(); //don't know why but there is not exception at all!

            //Concat
            //Concat method adds items, from another sequence, to the end of the sequence.
            var citrus = new[] { "grapefruit", "lemon", "lime", "orange" };
            var justBerries = new[] { "blackberry", "blueberry", "raspberry" };
            var newSequence = berries.Concat(citrus);

            //DefaultIfEmpty
            //The DefaultIfEmpty method gets either the original sequence or a sequence with a singe default value, if the original sequence is empty(contains no item);
            var bytes = new[] { 1, 2, 3, 4 };
            var defaultIfEmpty = bytes.DefaultIfEmpty(); //returns whole array

            var emptyArray = Enumerable.Empty<int>();
            var defaultIfEmpty2 = emptyArray.DefaultIfEmpty(); //returns array with one value = 0. because 0 is the value by default for int.
            //Parameters:  The sequence to return the specified value for if it is empty.
            var defaultIfEmpty3 = emptyArray.DefaultIfEmpty(123);  // returns 123 because emptyArray is empty and '123' was sent as argument to DefaultIfEmpty method

            //OfType
            // The OfType method allows you to select items (of homogenous type) from that sequence and produce an IEnumerable<T> instance
            //OfType method selects only items of specified type
            var list = new ArrayList { "Alpha", 123, "Beta", "Gamma" };
            var convertedList = list.OfType<string>(); // returns "Alpha", "Beta", "Gamma"  baceuse 'string' type was specified

            //Prepend ???? the same as Append -> there is no this method
            //The Prepend method adds a single item to the start of the sequence
            var collection = new[] { "grapefruit", "lemon", "lime", "orange" };
            //var newCollection = collection.Prepend();

            //Select
            //The Select method alters every item, in a senquence
            var citrus2 = new[] { "grapefruit", "lemon", "lime", "orange" };
            var selectedCollection = citrus2.Select(x => x + " super");

            //SelectMany
            //The SelectMany method alters multiple sequences and lettens them into a single sequence.
            int[][] manyNumbers = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };
            var changedArray = manyNumbers.SelectMany(x => x.Concat(new int[] { 9999 }));

            //Skip
            //The Skip method skips a fixed number of items at the start of a sequence.
            var someArray = new[] { 'A', 'B', 'C' };
            var changedArray2 = someArray.Skip(1); // returns 'B', 'C'

            //SkipWhile
            //The SkipWhile skips items at the start of the sequence, while they meet a specified condition
            var someArray2 = new[] { 'A', 'B', 'C', 'D' };
            var skippedArray = someArray2.SkipWhile(x => x < 'B'); // returns 'B', 'C', 'D'

            //Take
            //The Take method takes a fixed number of items from the start of a sequence
            var someArray3 = new[] { 'A', 'B', 'C', 'D' };
            var someArray4 = someArray3.Take(2); // returns 'A', 'B'

            //TakeWhile
            //The TakeWhile method takes items, from the start of a sequence, while they meet a specified condition
            var someArray5 = new[] { 'A', 'B', 'C', 'D' };
            var someArray6 = someArray5.TakeWhile(x => x < 'D'); //returned 'A', 'B', 'C'

            //Where
            //The Where method takes all of the items that meet specified condition
            var collection1 = new List<string> { "Item", "Something", "Last thing" };
            var filteredCollection = collection1.Where(x => x.Contains("Some")); //returned only 'Something'

            //Zip
            //The Zip method combines a sequence with items from another sequence
            string[] citrus4 = { "grapefruit", "lemon", "lime", "orange" };
            char[] letters = { 'A', 'B', 'C', 'D' };
            var somethingNew = citrus4.Zip(letters, (fruit, letter) => $"{fruit} {letter}"); //it authomatically undersrtands: fruit -> one item in cutrus4, letter -> one item in letters.
            //And there is an opportunity to make my own collection using the elements from other 2 collections.
        }
    }
}

