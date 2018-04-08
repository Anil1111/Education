﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Enums
{
    enum MyEnum //все константы будут int
    {
        Zero, // = 0
        One  = 1,
        one = One,
        Two = 2,
        Three, // = 3
        Four, // = 4
        Five = 5,
        //Six,
        Seven, // = 6 т.к после 5 идет 6.
        Eight = 8,
        Nine,
        Ten = 10,
        Infinite = 255
    }
}
