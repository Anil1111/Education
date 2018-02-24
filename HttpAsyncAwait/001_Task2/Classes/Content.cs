using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Task2.Classes
{
    class Content
    {
        public Content Contents { get; set; }

        public void ShowContent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Contents);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
