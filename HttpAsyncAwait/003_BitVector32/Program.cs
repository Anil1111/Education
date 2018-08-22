using System;
using System.Collections.Specialized;

namespace _003_BitVector32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Суть масок в том, чтобы управлять отдеьными битами.

            var vector = new BitVector32(0);
            //Метод BitVector32.CreateMask() по умолчанию создает маску где задействоан только первый бит.
            int firstBit = BitVector32.CreateMask();          // ... 0000 0001 B - 1D //одна цифра - задействована - 1 байт
            int secondBit = BitVector32.CreateMask(firstBit); // ... 0000 0010 B - 2D //две цифры задействованы - 2 байта
            int thirdBit = BitVector32.CreateMask(secondBit); // ... 0000 0100 B - 4D //три задействованы - 4 байта(а занято может быть либо 2 либо 4)

            Console.WriteLine(firstBit + " " + secondBit + " " + thirdBit); // Test

            //true - это 1, false - это 0
            vector[firstBit] = true; 
            vector[secondBit] = true;

            Console.WriteLine($"{vector.Data} должно быть 3");
            Console.WriteLine(vector.ToString());

            var newVector = new BitVector32(4);  // ... 0000 0100 B - 4D
            Console.WriteLine(newVector);

            //берем значение бита по маске
            bool bit1 = newVector[firstBit];  //false
            bool bit2 = newVector[secondBit]; //false
            bool bit3 = newVector[thirdBit];  //true

            Console.WriteLine($"bit1 = {bit1}, bit2={bit2}, bit3 = {bit3}");

            //Delay
            Console.ReadKey();
        }
    }
}
