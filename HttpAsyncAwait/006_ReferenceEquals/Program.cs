using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ReferenceEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReferenceEquals сравнивает НЕ обьекты, а ССЫЛКИ! Т.е сравниваются значения адресов объектов в памяти
            //, которые лежат в obj1 и obj2(тот int`овый адрес).
            //Т.е на куче есть обьект. в а переменной obj1 и obj2 есть АДРЕС этого объекта. Так вот эти адреса и сверяются.
            Object obj1 = new Object();
            Object obj2 = new Object();
            //ReferenceEquals проверяет НЕ HashCod`ы!!  И даже если он будут одинакові, как в предидущем примере, то все равно будут сверятся ССЫЛКИ на объекты!
            Console.WriteLine(Object.ReferenceEquals(obj1, obj2));

            obj1 = obj2;

            Console.WriteLine(Object.ReferenceEquals(obj1, obj2));

            //Delay
            Console.ReadKey();
        }
    }
}
