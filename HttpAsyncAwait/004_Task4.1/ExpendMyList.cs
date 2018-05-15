using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task4._1
{
    public static class ExtendMyList
    {
        public static T[] GetMyArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = list[i];
            }

            return temp;
        }
    }
}
