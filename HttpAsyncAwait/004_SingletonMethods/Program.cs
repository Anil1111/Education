using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _004_SingletonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //The singleton methods force immediate materialization of at least a portion of the sequence. 
            //These methods include: 
            //Aggregate, All, Any, Average, Contains, Count, ElementAt, ElementAtOrDefault, 
            //First, FirstOrDefault, Last, LastOrDefault, LongCount, Max, Min, SequenceEqual, 
            //Single, SingleOrDefault, Sum, ToArray, ToDictionary, ToList, and ToLookup.

            //Aggregate
            //The Aggregate method accumulates the items in a sequence to return a singleton, aggregate value. 
            //The code below is just an example. It is a terrible implementation of String.Join, which is far more appropriate if you ever need to simply aggregate strings.

            string[] berries = { "blackberry", "blueberry", "raspberry" };
            //debug and it will be clear
            string aggregate = berries.Aggregate((accumulator, item) => accumulator + " " + item); //return: blackberry blueberry raspberry

            var a = string.Join(" ", berries); //The same result
                                               //Warning: If the sequence has zero items, an exception will occur.If the sequence has only one item, 
                                               //the first item is simply returned, without ever invoking the method you provide.For all other sequences, 
                                               //the first invocation of your method will be called with the first two items of the sequence.

            //All
            //The All method gets a Boolean value indicating if all items in a sequence match the specified condition.
            //This method stops when it reaches the first item that does not match the specified condition.
            char[] letters = { 'A', 'B', 'C', 'D' };
            bool all = letters.All(x => Char.IsLetter(x)); //returns true

            //Any
            //The Any method gets a Boolean value indicating if any items in a sequence match the specified condition. 
            //This method stops when it reaches the first item that matches the specified condition.
            char[] letters1 = { 'A', 'B', 'C', 'D' };
            bool any = letters1.Any(x => Char.IsLetter(x));

            //Average
            //The Average method averages all of the imes in the sequence and returns a floating point result.
            byte[] bytes = { 1, 2, 3, 4 };
            float average = bytes.Average(x => (float)x);

            //Contains
            //The Contains method gets a Boolean value indicating if the sequence contains the specified item. 
            //This method stops on the first item that matches the specified item.
            char[] letters2 = { 'A', 'B', 'C', 'D' };
            bool contains = letters2.Contains('C');

            //Count
            //The Count method gets the number of items in the sequence.
            // The Length property would be more efficient here
            byte[] byte4 = { 1, 2, 3, 4 };
            int count = byte4.Count();
            Console.WriteLine($"Count: {count}");

            //The Count method can also get the number of items in a sequence that match a specified condition.

            var count2 = byte4.Count(x => x > 3); //returns 1
                                                  //Warning: IEnumerable<T>.Count method must evaluate every item in the sequence and can be quite resource intensive.
                                                  //It should not be confused with the ICollection<T>.Count property or the Array.Length property. 
                                                  //Both of these (most often) simply return a pre - existing count and are(generally) not resource intensive.

            //ElementAt
            //The ElementAt method gets the item at the specified zero-based index within the sequence.
            byte[] bytes5 = { 1, 2, 3, 4 };
            byte elementAt = bytes5.ElementAt(1);
            Console.WriteLine($"ElementAt: {elementAt}"); //returns 2

            //byte elementAt1 = bytes5.ElementAt(10); // Unhandled Exception: System.ArgumentOutOfRangeException: Index was out of range. 
                                                    //Must be non-negative and less than the size of the collection.

            //Warning: This should not be confused with indexing functionality provided by arrays and lists.
            //Unlike true indexing, the ElementAt method must evaluate and skip all items prior to the specified index. 
            //It is functionally equivalent to the following LINQ: IEnumerable<T>.Skip(index).First().

            //ElementAtOrDefault
            //The ElementAtOrDefault method gets the item at the specified zero-based index within the sequence, 
            //if the specified item does not-exist, it returns a default value.
            byte[] bytes6 = { 1, 2, 3, 4 };
            byte elementAtOrDefault = bytes6.ElementAt(1);
            Console.WriteLine($"ElementAtOrDefault: {elementAtOrDefault}"); //returns 2

            elementAtOrDefault = bytes6.ElementAtOrDefault(-1);
            Console.WriteLine($"ElementAtOrDefault: {elementAtOrDefault}"); //returns 0

            //Warning: This should not be confused with indexing functionality provided by arrays and lists.
            //Unlike true indexing, the ElementAt method must evaluate and skip all items prior to the specified index. 
            //It is functionally equivalent to the following LINQ: IEnumerable<T>.Skip(index).FirstOrDefault().

        }
    }
}
