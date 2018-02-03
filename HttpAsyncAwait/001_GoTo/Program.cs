using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Оператор безусловного перехода - goto.
            // Label - это метка , на которую будет произведен переход оператором goto.
            Label:
            Console.WriteLine("Hello");
            goto Label;
        }
    }
}
