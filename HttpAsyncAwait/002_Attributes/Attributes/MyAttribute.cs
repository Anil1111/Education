using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Attributes.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class MyAttribute : Attribute
    {
        private readonly string date;
        public string Date => date;

        public MyAttribute(string date)
        {
            this.date = date;
        }

        private int number;

        public int Number
        {
            get => number;
            set => number = value;
        }

        public static int someField;
    }
}
