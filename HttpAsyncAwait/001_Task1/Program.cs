using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _001_Task1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side length");
            var side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second side length");
            var side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Area = {rectangle.Area}");
            Console.WriteLine($"Perimeter = {rectangle.Perimeter}");
        }
    }
}
