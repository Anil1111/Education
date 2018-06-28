using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Switch_Case
{
    /// <summary>
    /// Теперь в С# 7.0 в switch можно использовать сопоставления.
    /// </summary>
    class Program
    {
        static (int sum, int count) Method(IEnumerable<object> list)
        {
            var tupleVariable = (firstField: 0, secondField: 0);

            foreach (var item in list)
            {
                switch (item)
                {
                    case int i:
                        tupleVariable.firstField += i;
                        tupleVariable.secondField++;
                        break;

                    case IEnumerable<object> l when l.Any():
                        var tl = Method(l);
                        tupleVariable.firstField += tl.sum;
                        tupleVariable.secondField += tl.count;
                        break;

                    case IEnumerable<object> l:
                    case null:
                        break;
                }
            }

            return tupleVariable;
        }
        static void Main(string[] args)
        {
            object[] numbers = { 0b1, 0b10, new object[] { 0b10, 0b100, 0b10_000 }, 0b0001 };
            var t = Method(numbers);

            Console.WriteLine($"Count {t.count}, Sum {t.sum}");

            //Delay
            Console.ReadKey();
        }
    }
}
