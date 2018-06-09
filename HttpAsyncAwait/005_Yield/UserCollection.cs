using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Yield
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            while (true)
            {
                yield return "Hello world";
            }
            // в MoveNext мы некому полю присваиваем "Hello world" и MoveNext безусловно возвращает true
        }
    }
}
