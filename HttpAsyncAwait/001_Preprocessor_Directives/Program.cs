using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Preprocessor_Directives
{
    //кто такой препроцессор? Это специальный механизм, встроенный в Visual Studio, который и обслуживает нас в сеансе пользования.
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            Console.WriteLine("Hello...");

            #endregion

            //Delay
            Console.ReadKey();
        }
    }
}
