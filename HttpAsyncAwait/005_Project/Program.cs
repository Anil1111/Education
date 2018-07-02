
extern alias L1; //аллиасы должны быть в самом верху
extern alias L2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Project
{

    //Ситуация:
    //Совпадение имен двух пространств имен в разных борках и совпадение имен стереотипов в этих пространствах имен.

    //Для подключения алиаса выполните следующие действия:
    //1. Добавьте в References необходимые сборки Library1 и Library2.
    //2. Откройте папку References.
    //3. Правой кнопкой мыши кликните по сборке Library1, откроется контекстное меню, в котором выберите пункт Properties.
    //4. В открывшимся окне свойств, в свойстве Aliases, замените значение global на L1.
    //5. Те же действия выпонлить для сборки Library2.
    class Program
    {
        static void Main(string[] args)
        {
            L1._005_ClassLibrary1.Class1 my1 = new L1._005_ClassLibrary1.Class1();
            L2._005_ClassLibrary1.Class1 my2 = new L2._005_ClassLibrary1.Class1();

            my1.Method();
            my2.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
