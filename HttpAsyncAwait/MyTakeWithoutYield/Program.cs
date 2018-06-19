using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTakeWithoutYield
{
    public static class MyEnumerable2 //This class simply provides the MyTake2 extension method and one inner class.
    {
        public static IEnumerable<T> MyTake2<T>(this IEnumerable<T> items, int count) //We simply create an instance of MyTakeEnumerable to wrap the original sequence.
        {
            return new MyTakeEnumerable<T>(items, count);
        }

        private class MyTakeEnumerable<T> : IEnumerable<T> //This inner class simply WRAPS ORIGINAL SEQUENCE.    
        //It provides a new GetEnumerator method that gets an enumerator, for the original sequence, and wraps it in an instance of MyTakeEnumerator.
        {
            private IEnumerable<T> items;
            private int count;

            public MyTakeEnumerable(IEnumerable<T> items, int count)
            {
                this.items = items;
                this.count = count;
            }

            public IEnumerator<T> GetEnumerator()
            {
                return new MyTakeEnumerator(items.GetEnumerator(), count);
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            private class MyTakeEnumerator : IEnumerator<T> //This inner class simply WRAPS ENUMERATOR from the original sequence and limits it to the requested number of items.
            {
                private IEnumerator<T> enumerator;
                private int count;
                private int index;

                public MyTakeEnumerator(IEnumerator<T> enumerator, int count)
                {
                    this.enumerator = enumerator;
                    this.count = count;
                }

                public void Dispose() => enumerator.Dispose();

                public bool MoveNext() => index++ <= count && enumerator.MoveNext();

                public void Reset() => enumerator.Reset();

                public T Current => enumerator.Current;

                object IEnumerator.Current => Current;
            }
        }
    }
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
            var myCollection = GetFibonacciNumber().MyTake2(30);
        }
        //Summing It Up
        //  To summarize the summary of the summary: people are a problem. – Douglas Adams
        // When C# encounters a yield keyword, within a method, it performs a little bit of magic. 

        //Your method is changed so that it simply creates an IEnumerable/IEnumerator class on your behalf. It then returns an instance of this new class.
        //So where did your code go? It is (essentially) moved into the MoveNext method of the IEnumerator.
        // This is why none of your code is actually executed when you call the original method. 
        //Your actual code now resides in MoveNext.It is not executed until you call GetEnumerator and then MoveNext.
    }
}
