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
        private static string GetLastWord(string words) => words.Substring(words.LastIndexOf(' ') + 1);
        private static string GetFirstWord(string words) => words.Substring(0, words.IndexOf(' '));
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


            //First
            //The First method gets the first item in the sequence or the first item matching a specified condition.
            //If it is acceptable for the sequence to be empty, the FirstOrDefault method is preferable.
            //If it is not acceptable for more than one item to be in the sequence, the Single/SingleOrDefault methods are preference.
            string[] berriess = { "blackberry", "blueberry", "raspberry" };
            string first = berriess.First(); //returns blackberry

            first = berriess.First(x => x.Contains("r")); //returns raspberry

            byte[] emptyBytes = { };
            //byte firstEmpty = emptyBytes.First(); // Unhandled Exception: System.InvalidOperationException: Sequence contains no elements


            //FirstOrDefault
            //The FirstOrDefault method gets the first item in the sequence or the first item matching a specified condition. 
            //It will return a default value, if the sequence is empty. 
            //If it is not acceptable for more than one item to be in the sequence, the SingleOrDefault method is preference.

            string[] berries1 = { "blackberry", "blueberry", "raspberry" };
            string firstOrDefault = berries.FirstOrDefault(); //returns blackberry

            firstOrDefault = berries1.FirstOrDefault(x => x.StartsWith("r")); //returns raspberry

            byte[] emptyBytes1 = { };
            byte firstEmpty1 = emptyBytes1.FirstOrDefault(); //returns 0


            //Last
            //The Last method gets the last item in the sequence. 
            //If it is acceptable for the sequence to be empty, the LastOrDefault method is preferable.
            string[] berries9 = { "blackberry", "blueberry", "raspberry" };
            string last = berries9.Last(); //returns raspberry

            var last1 = berries9.Last(x => x.StartsWith("b")); //returns blueberry

            byte[] emptyBytess = { };
            //byte lastEmpty = emptyBytes.Last(); // Unhandled Exception: System.InvalidOperationException: Sequence contains no elements

            //Warning: Unlike the First method, the Last method must visit every item in the sequence. 
            //This can be very resource intensive for larger sequences.


            //LastOrDefault
            //The LastOrDefault method gets the last item in the sequence or the last item matching a specified condition. 
            //It will return a default value, if the sequence is empty.
            string[] berries11 = { "blackberry", "blueberry", "raspberry" };
            string lastOrDefault = berries11.LastOrDefault(); //returns raspberry

            var lastOrDefault1 = berries11.LastOrDefault(x => x.StartsWith("b")); //returns blueberry

            byte[] array = { };
            byte lastEmpty = array.LastOrDefault(); //returns 0

            //Warning: Unlike the FirstOrDefault method, the LastOrDefault must visit every item in the sequence. 
            //This can be very resource intensive for larger sequences.


            //LongCount
            //The LongCount method gets the number of items in the sequence (as a 64 bit count).
            // The Length property would be more efficient here
            byte[] bytess1 = { 1, 2, 3, 4 };
            long countt = bytess1.LongCount(); //returns 4

            //The LongCount method can also get the number of items in a sequence that match a specified CONDITION (as a 64 bit count).

            var count3 = bytes.LongCount(x => (x + 1) == 3); //returns 1

            //Warning: IEnumerable<T>.LongCount method must evaluate every item in the sequence and can be quite resource intensive.
            //It should not be confused with the ICollection<T>.Count property or the Array.Length property. 
            //Both of these (most often) simply return a pre-existing count and are (generally) not resource intensive.


            //Max
            //The Max method gets the greatest value in a sequence.

            byte[] bytess = { 1, 2, 3, 4 };
            var maxValue = bytess.Max(); //returns 4

            string[] textNumbers = { "1", "2", "3", "4" };
            string maxValueStiring = textNumbers.Max(); //returns "4"
            int maxValueFromString = textNumbers.Max(x => int.Parse(x)); //returns 4


            //Min
            //The Min method gets the smallest value in a sequence.
            byte[] bytes11 = { 1, 2, 3, 4 };
            byte min = bytes11.Min(); //return 1

            string[] textNumberss = { "1", "2", "3", "4" };
            string minFromString = textNumberss.Min(); //returns "1"
            int minValue = textNumbers.Min(x => int.Parse(x)); //returns 1


            //SequenceEqual
            //The SequenceEquals method gets a Boolean value indicating 
            //if two sequences have an equal number of items that are equal and appear in the same order.

            byte[] bytes12 = { 1, 2, 3, 4, 5 };
            byte[] bytes123 = { 1, 2, 3, 4, 5 };
            bool sequenceEqual = bytes12.SequenceEqual(bytes123); //returns true
            bool sequenceEqual2 = bytes12.SequenceEqual(bytes123.Take(bytes12.Length - 1)); //returns false


            //Single
            //The Single method gets the first item in the sequence or the first item matching a specified condition. 
            //This method throws an exception if there is not exactly one matching item. !!!ВОТ ЧЕМ ОН ОТЛИЧАЕТСЯ ОТ First
            //If it is acceptable for the sequence to be empty, the SingleOrDefault method is preferable.

            string[] berry = { "blackberry" };
            string single = berry.Single(); //return blackberry

            byte[] emptyArray = { };
            //byte singleEmpty = emptyArray.Single(); // Unhandled Exception: System.InvalidOperationException: Sequence contains no elements

            string[] berries5 = { "blackberry", "blueberry", "raspberry" };

            //string single2 = berries5.Single(x => x.StartsWith("b")); // Unhandled Exception: System.InvalidOperationException: Sequence contains more than one element


            //SingleOrDefault
            //The SingleOrDefault method gets the first item in the sequence and throws an exception 
            //if more than one item exists and returns a default value if the sequence is empty.

            string[] berry6 = { "blackberry" };
            string singleOrDefault = berry6.SingleOrDefault(); //returns blackberry

            byte[] emptyArray2 = { };
            byte singleOrDefault3 = emptyArray2.SingleOrDefault(); //returns 0

            string[] berries8 = { "blackberry", "blueberry", "raspberry" };
            //string singleOrDefault5 = berries8.SingleOrDefault();  // Unhandled Exception: System.InvalidOperationException: Sequence contains more than one element


            //Sum
            //The Sum method gets a sum of all of the values in the sequence.

            byte[] bytes9 = { 1, 2, 3, 4 };
            float sum = bytes9.Sum(x => (float)x); //returns 10


            //ToArray
            //The ToArray method converts the sequence to an array of TItem[].
            var bytesx = new List<int> { 1, 2, 3, 4 };
            int[] arrayyInts = bytesx
                .Take(2)
                .ToArray();
            //Warning: This method should be avoided unless strictly necessary. 
            //Executing this method causes every item in the sequence to be evaluated. 
            //It also requires that all members of the sequence are present in memory at the same instant. 
            //For larger sequences, this can be very resource intensive.


            //ToDictionary
            //The ToDictionary method converts the sequence to a System.Collections.Generic.Dictionary<TKey, TITem>.
            string[] numberFruits = { "1 Apple", "2 Orange", "3 Cherry" };
            Dictionary<int, string> fruiteDictionary = numberFruits.ToDictionary(
                x => int.Parse(GetFirstWord(x)),x=>GetLastWord(x));

            //Warning: This method should be avoided unless strictly necessary. 
            //Executing this method causes every item in the sequence to be evaluated. 
            //It also requires that all members of the sequence are present in memory at the same instant. 
            //For larger sequences, this can be very resource intensive.


            //ToList
            //The ToList method converts the sequence to a System.Collections.Generic.List<TItem>.

            byte[] bytes999 = { 1, 2, 3, 4 };
            List<byte> byteList = bytes999.ToList();
            //Warning: This method should be avoided unless strictly necessary. 
            //Executing this method causes every item in the sequence to be evaluated. 
            //It also requires that all members of the sequence are present in memory at the same instant. 
            //For larger sequences, this can be very resource intensive.


            //ToLookup
            //The ToLookup method converts the sequence to a System.Linq.Lookup<TKey, TItem> instance.
            string[] numberFruits3 = { "1 Apple", "2 Orange", "3 Cherry" };
            ILookup<int, string> fruitLookup = numberFruits3.ToLookup(
                item => int.Parse(GetFirstWord(item)));
            //Warning: This method should be avoided unless strictly necessary. 
            //Executing this method causes every item in the sequence to be evaluated.
            //It also requires that all members of the sequence are present in memory at the same instant.
            //For larger sequences, this can be very resource intensive.
        }
    }
}
