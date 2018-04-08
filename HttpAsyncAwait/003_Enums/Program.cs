using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Перечисления.
namespace _003_Enums
{
    // МОЖНА использовать ПСЕВДОНИМ для любого целого типа данных C#(byte, sbyte,short,ushort,int,uint,long,ulong)
    //раньше - нельзя, а теперь МОЖНА
    // МОЖНА использовать любой системный целый тип данных C#(Byte, SByte,Int16,UInt16,Int32,UInt32,Int64,UInt64)
    enum MyEnum : Int16
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyEnum.One);

            //Delay
            Console.ReadKey();
        }
    }
}
