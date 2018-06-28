using static System.Console;
using static System.Math;

namespace _004_StaticClassImport
{
    /// <summary>
    /// В C# появилась возможность импотировать с помощью ключевого слова using статические классы.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Writeline without 'Console.'");

            WriteLine(Pow(2,3));

            ReadKey();
        }
    }
}
