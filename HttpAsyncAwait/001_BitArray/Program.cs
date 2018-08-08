using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _001_BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray bits = new BitArray(3); //нету конструктора по умолчанию.

            bits[0] = false;
            bits[1] = true;
            bits[2] = false;
            Console.WriteLine(bits.Length);

            //Для изменения размера коллекции необходимо воспользоваться свойством Length
            bits.Length = 4;
            bits[3] = true;
            Console.WriteLine(bits.Length);
            Console.WriteLine(bits.Count);

            //Ценность BitArray в том, что он позволяет выполнить логические операции над двумя объектами(смотри след. пример)

            //Delay
            Console.ReadKey();
        }
    }
}
