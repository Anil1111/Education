using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _009_Task33
{
    class Program
    {
        private delegate double MyDelegate(LittleDelegate[] array);

        private delegate int LittleDelegate();
        static void Main(string[] args)
        {
            MyDelegate myDelegate = (array) =>
            {
                var list = array.ToList();
                var somenumber = 0;
                foreach (var item in list)
                {
                    var invokedItem = item.Invoke();
                    somenumber += invokedItem;
                }

                return somenumber/list.Count;
            };

            LittleDelegate[] littleArray = new LittleDelegate[2];
            littleArray[0] = () => new Random().Next(1, 500);
            littleArray[1] = () => new Random().Next(1, 500);

            var result = myDelegate(littleArray);

            //Delay
            Console.ReadLine();
        }
    }
}
