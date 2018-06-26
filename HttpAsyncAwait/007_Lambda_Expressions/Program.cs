using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda expressions were introduced in .NET 3.0 to accompany LINQ.
            //They provide a syntactical short cut to creating and sharing anonymous method declarations.
            //With Lambda expressions, the following is possible:

            string[] berries = { "blackberry", "blueberry", "raspberry" };
            string firstBerry = berries.First(item => item.StartsWith("r"));
            Console.WriteLine($"First: {firstBerry}"); // First: blackberry

            //The Lambda expression consists of parameters(left side) and method logic(right side), separated by “=>”:

            //item => item.StartsWith("r")

            //Prior to Lambda expressions, to achieve the same goal we would be forced to declare a method:

            bool StartswithAnR(string item)
            {
                return item.StartsWith("r");
            }

            //And pass its delegate as a parameter:

            firstBerry = berries.First(StartswithAnR);
            Console.WriteLine($"First: {firstBerry}");    // First: blackberry


            //item => item.StartsWith("r")
            //With the previous Lambda method, we are essentially declaring an anonymous method that 
            //accepts one parameter (item) and returns a value. 
            //The type of the value(string) is inferred by the way that item is used.
            //The type of the return value(bool) is similarly inferred.

            //C# also provides a whole bunch of pre-rolled delegates. !!HOVER OVER First at 34
            //This allows us to have type-safe method delegates for parameter and variable declarations. 
            //One of these is the Func delegate, its final type parameter (bool in this case) is the return value type, 
            //all previous type parameters (string in this case) indicate the type of parameters expected by the function/method.

            //Using the same Lamba expression from before we can assign it to a delegate and then use that delegate:

            Func<string, bool> predicate = item => item.StartsWith("r");
            bool startWith = predicate.Invoke("right"); // true

            Func<string, string, string> concatenate = (textA, textB) => textA + textB;
            string result = concatenate("Hello", " World"); //Hello World
        }
    }
}
