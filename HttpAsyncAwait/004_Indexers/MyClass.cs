using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Indexers
{
    class MyClass
    {
        private int[,] array = new int[3,3];

        public int this[int index1, int index2]
        {
            get => array[index1, index2];
            set => array[index1, index2] = value;
        }
    }
}
