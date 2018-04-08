using System.Net.NetworkInformation;

namespace _004_Enums
{
    enum MyEnum //все константы будут int
    {
        Zero, // = 0
        One, // = 1
        one = One,
        Two=2,
        Three, // = 3
        Four, // = 4
        Five =5, 
        Six = Nine,
        Seven, // = 10
        Eight =8, //Если не указать значение ЯВНО, то на 14 строке будет ошибка!
        Nine, 
        Ten =10,
        Infinite =255
    }
}
