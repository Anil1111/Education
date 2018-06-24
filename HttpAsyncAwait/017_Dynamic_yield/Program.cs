using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Dynamic_yield
{
    class UserCollection
    {
        public static IEnumerable Generator()
        {
            //Вовзащает IEnumerable в экземплярами анонимного типа внутри
            yield return new { Key = 0, Value = "Zero" };
            yield return new { Key = 1, Value = "One" };
            yield return new { Key = 2, Value = "Two" };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //когда я пишу var, то все приводится к object`У. А на object`е мы не видим Key и Value.
            //UpCast реализует инкапсуляцию.
            //Ad-hoc полиморфизм (Cast к dynamic) -> Cast БЕЗ ИНКАПСУЛЯЦИИ. Полиморфизм - сопособность обьект с одинаковой спецификацией иметь
            //разную реализацию. Т.е мы как бы привелись и у нас дожна быть доступна реализация, которая соответствует типу к которому
            //мы привелись. А у нас доступно то, чего не должно быть доступно - т.е инкапсуляции нету.

            //Ad-hoc полиморфизм - это ПРИВЕДЕНИЕ К БАЗОВОМУ ТИПУ БЕЗ ИНКАПСУЛЯЦИИ и это возможно только к приведению к dynamic
            foreach (dynamic item in UserCollection.Generator())
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
