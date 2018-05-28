using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Console
{
    public delegate void MyDelegate(string s);
    class Program
    {
        public static event MyDelegate MyEvent;
        static void Main(string[] args)
        {
            new Presenter();
            string s = "";
            while (true)
            {
                s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    MyEvent.Invoke(s);
                }
            }
        }
    }
}
