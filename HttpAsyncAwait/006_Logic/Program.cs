using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Логический сдвиг

            byte operand = 0x81;  //1000 0001
            Console.WriteLine("Число до сдвига: {0:X}", operand);

            //Логический сдвиг числа влево.

            operand = (byte)(operand << 2); //0000 0100
            Console.WriteLine("Число после сдвига слево: {0:X}", operand);

            //Логический сдвиг числа вправо.

            operand = (byte)(operand >> 1); //0000 0010

            Console.WriteLine("Число после сдвига вправо: {0:X}", operand);

            //Delay
            Console.ReadKey();
        }
    }
}
