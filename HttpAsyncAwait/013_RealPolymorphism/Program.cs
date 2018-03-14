using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_RealPolymorphism
{
    class BaseClass
    {
        
    }

    class Der1:BaseClass    //Der1 - это футболка
    {
        
    }
    class Der2: BaseClass   //Der2 - это рубашка
    {

    }

    class Container         // это я
    {
        public BaseClass field;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();

            container.field= new Der1();  // я сначала одел фурболку
            Console.WriteLine(container.field.GetHashCode());   //хэш коды разные т.к Der1 и Der2 разные обьекты!

            container.field = new Der2(); // а потом одел футболку
            Console.WriteLine(container.field.GetHashCode());   //хэш коды разные т.к Der1 и Der2 разные обьекты!

            //Delay
            Console.ReadKey();
        }
    }
}
