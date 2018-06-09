using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Yield
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            yield break; //используется тогда, когда коллекция пустая и чтобы не было ошибки в foreach.
        }
        //например - если из базы данных вернулась пустая колекция - то вернуть yield break
        // если в кратце - то MoveNext() просто будет возвращать false! смотри следующий пример
    }
}
