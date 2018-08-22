using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_BitArray_BitVector32
{
    class Program
    {
        static void Main(string[] args)
        {
            //BitArray - коллекция битов(булевых значений)
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
            //-------------------------------------------------------------------------------------

            //BitVector32 - это коллекция ФИКСИРОВАННОЙ ДЛИНЫ В 32 БИТА, хранит одно целочисленное значение, и предназнчена
            //для того, чтобы им оперировать т.е оперировать побитовыми масками.
            //10, 50, 500, 500 - это просто максимальные значения(не совсем. например число 50 захватывает 6 битов и можно записать 111111 вместо 110010)
            //, которые могут раниться в секции.
            BitVector32.Section firstSection = BitVector32.CreateSection(10); // 0xA Hex - 1010 Bin   //4 байта 
            BitVector32.Section secondSection = BitVector32.CreateSection(50, firstSection); // 0x32 Hex - 110010 Bin
            BitVector32.Section thirdSection = BitVector32.CreateSection(500, secondSection); // 0x1F4 Hex 111110100 Bin
            BitVector32.Section fourthSection = BitVector32.CreateSection(500, thirdSection);
            var packedBits = new BitVector32(0);

            packedBits[firstSection] = 10;   // ....000000000000001010
            packedBits[secondSection] = 50;  // ....000000001100101010  //т.е добавилось 110010 после 1010
            packedBits[thirdSection] = 500;  //и так далее
            packedBits[fourthSection] = 499; //и так далее
            //Если переполнить максимальное число в одной секции, то числа в другой секции будут переполнены и немного "подпорчены".
            //Нужно стараться избегать такого.

            Console.WriteLine(packedBits[firstSection]);  //выведет 10
            Console.WriteLine(packedBits[secondSection]); //выведет 50
            Console.WriteLine(packedBits[thirdSection]);  //выведет 500
            Console.WriteLine(packedBits[fourthSection]); //выведет 499

            Console.WriteLine(packedBits);  //packedBits = {BitVector{000000000000 111110100 110010 1010}}
            Console.WriteLine(packedBits.Data); //выводится число, которое представляет собой последовательность бит.
            //это число нам ничего не говорит

            //Delay
            Console.ReadKey();
        }
    }
}
