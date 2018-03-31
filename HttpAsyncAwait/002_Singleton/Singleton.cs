using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Singleton
{
    //Singleton - мы должны обеспечить , что в системе ЭКЗЕМПЛЯР этого класса будет только один.
            //(может быть на всегда 1, а может быть 2 или 3) - короче точное количество экземпляра
    class Singleton
    {
        private static Singleton instance = null;

        //Конструктор - "protected"
        protected Singleton()  //почему protrected? чтобы унаследовался и в производном классе вызвал этот конструктор
        {                       // и построил экземпляр.

        }

        //Фабричный метод
        public static Singleton GetInstance()
        {
            //Если: обьект еще не создан (1)
            if (instance== null)
            {
                //То: создаем новый экземпляр (2)
                instance = new Singleton();
            }
            //Иначе: возвращаем ссылку на существующий обьект (3)
            return instance;
        }
    }
}
