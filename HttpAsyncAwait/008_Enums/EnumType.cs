using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Enums
{
    enum MyEnum
    {
        Zero, // = 0
        One = 1,
        one = One,
        Two = 2,
        Three, // = 3
        Four, // = 4
        Five = 5,
        Six = Nine,
        //Seven, 
        Eight = 8, //Если не указать явно, то на 18 строке будет ошибка
        Nine,
        Ten = 10,
        Infinite = 255
    }
}
