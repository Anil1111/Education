using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static class SimpleExtension
    {
        public static string TrimMyStringExtended(this string value) => value.Trim();
    }
    class Program
    {
        public static string TrimMyStringNormal(string value) => value.Trim();
        static void Main(string[] args)
        {
            var value = "Some value";

            var trimmedValue = TrimMyStringNormal(value);

            var trimmedValueByExtension = value.TrimMyStringExtended(); //In truth, behind the scenes, the compiler simply translates this call into the following call:
            var trimmedLiteral = "Roma".TrimMyStringExtended();
        }
    }
}