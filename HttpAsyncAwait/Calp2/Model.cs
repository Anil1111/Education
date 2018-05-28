using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calp2
{
    class Model
    {
        public string Add(int a, int b) => (a + b).ToString();
        public string Sub(int a, int b) => (a - b).ToString();
        public string Mul(int a, int b) => (a * b).ToString();

        public string Div(int a, int b)
        {
            if (b != 0)
            {
                return ((double) a / b).ToString();
            }

            return "На ноль делить нельзя.";
        }
    }
}
