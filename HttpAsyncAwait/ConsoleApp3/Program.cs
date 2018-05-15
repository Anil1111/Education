using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public struct MyStruct { }

        public class Roman { }
        static void Main(string[] args)
        {
            int? a = null;
            //Nullable<string> b; - недопустимое поле.
            //Nullable<bool> b; - недопустимое поле.

            //public struct Nullable<T> where T : struct
            //Nullable<Roman> a; НЕЛЬЗЯ Т.К КЛАСС
            Nullable<MyStruct> b; //ошибки нету т.к это СТРУКТУРА

            int? c = null;
            int? n = null;
            var d = c == n; //d будет true!
            var q = c <= n; //q будет false!
            var e = c >= n; //e будет false!
        }
    }
}
