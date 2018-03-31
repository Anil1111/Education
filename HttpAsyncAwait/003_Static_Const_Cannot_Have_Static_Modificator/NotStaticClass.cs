using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _003_Static_Const_Cannot_Have_Static_Modificator
{
    class NotStaticClass
    {
        //Константы не могут быть статическими.
        //public static const float e = 2.71123456789f;

        //Поле, не может быть обьявлено как static const, поле const уже по своему поведению является статическим.
        //Поле const ОТНОСИТСЯ К ТИПУ, А НЕ К ЭКЗЕМПЛЯРАМ ТИПА.
        //По этому, к полям const можно обращаться с использованием той же нотации ИмяКласса.ИмяЧлена(на классе объекте...),
        //что и в используемой для статических полей.

        public const float e = 2.71123456789f;
    }
}
