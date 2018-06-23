using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var blockA = new Block(1,2,3,4);
            var blockB = new Block(4,3,2,1);

            var perimetersEqual = blockA.GetHashCode() == blockB.GetHashCode();
            Console.WriteLine($"Perimeters of blockA and blockB are equal = {perimetersEqual}");

            var c = blockA.Equals(blockB);
            Console.WriteLine($"blockA and blockB are equal = {c}");
            
            //Delay
            Console.ReadKey();
        }
    }
}
