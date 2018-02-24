using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Taskk2
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "ahahahha";
            Book book = new Book("CLR via C#", "Jeffrey Richter", content);

            book.Show(); 
            //Delay
            Console.ReadKey();
        }
    }
}
