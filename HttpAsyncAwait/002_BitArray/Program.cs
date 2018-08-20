using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _002_BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var bits1 = new BitArray(3)
            {
                [0] = true,
                [1] = true,
                [2] = true
            };

            var bits2 = new BitArray(3);
            bits2[0] = true;
            bits2[1] = false;
            bits2[2] = true;

            //Пришлось влепить так потому, что при выполнении операции, значение bits1 и bits2 меняется(ссылочный тип)
            
            var resultBits = (bits1.Clone() as BitArray)?.And(bits2.Clone() as BitArray);

            var resultBits2 = (bits1.Clone() as BitArray)?.Or(bits2.Clone() as BitArray);

            var resultBits3 = (bits1.Clone() as BitArray)?.Xor(bits2.Clone() as BitArray);

            var resultBits4 = (bits1.Clone() as BitArray).Not();

            foreach (var bit in resultBits)
            {
                Console.WriteLine(bit);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
