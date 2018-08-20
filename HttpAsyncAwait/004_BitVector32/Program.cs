using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_BitVector32
{
    class Program
    {
        static void Main(string[] args)
        {
            //для того чтобы сделаь герлянду и чтобы лампочки менялись одновременно - нужно использовать то секции.

            BitVector32.Section firstSection = BitVector32.CreateSection(10); // 0xA Hex - 1010 Bin   //4 байта
            BitVector32.Section secondSection = BitVector32.CreateSection(50, firstSection); // 0x32 Hex - 110010 Bin
            BitVector32.Section thirdSection = BitVector32.CreateSection(500, secondSection); // 0x1F4 Hex 111110100 Bin
            BitVector32.Section fourthSection = BitVector32.CreateSection(500, thirdSection); 
            var packedBits = new BitVector32(0);

            packedBits[firstSection] = 10;   // ....000000000000001010
            packedBits[secondSection] = 50;  // ....000000001100101010  //т.е добавилось 110010 после 1010
            packedBits[thirdSection] = 500;  //и так далее
            packedBits[fourthSection] = 499; //и так далее

            Console.WriteLine(packedBits[firstSection]);  //выведет 10
            Console.WriteLine(packedBits[secondSection]); //выведет 50
            Console.WriteLine(packedBits[thirdSection]);  //выведет 500
            Console.WriteLine(packedBits[fourthSection]); //выведет 499

            Console.WriteLine(packedBits);  //то, что нас интересует
            Console.WriteLine(packedBits.Data); //выводится число, которое представляет собой последовательность бит.
            //это число нам ничего не говорит

            //Delay
            Console.ReadKey();
        }
    }
}
