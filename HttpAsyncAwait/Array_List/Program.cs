using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList() { 1, "o", true }; //гетерогенная коллекция
            //Boxing
            myArrayList.Add("Hello"); //добавляется обьект в конец коллекции
            myArrayList.Add(2); //добавляется обьект в конец коллекции
            myArrayList.Sort(); // много других методов. А массивы этого делать не могут. Они могут только изменять значение.


            //Unboxing
            string s = (string)myArrayList[0];
            int a = (int)myArrayList[4];
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.Write(myArrayList[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
