using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Yield
{
    public class UserCollection
    {
        // yield требует специальной нотации - нужно чтобы метод возвращал IEnumerable
        public static IEnumerable Power() //то, что программа работает - это благодаря одному слову - yield
        {
            for (int i = 0; i < 10; i++)
            {
                yield return "Hello world! " + i;
            }

            yield return "The end";
        }

        //"Волшебное обьяснение".
        // Первый yield return видит, что он первый и "вешает мешочек" и забрасывает туда значение, к примеру "Hello world! ".
        // Другие yield`ы видят что мешочек есть и просто забрасывают в него свое значение.
        // Последний yield видит, что он последний и тогда "завязывает" мешочек и "выбрасывает" его как возвращаемое значение метода Power.

        //yield - оператор генерации программных кодов коллекции!

        //Техническое обьянение.
    }
}
