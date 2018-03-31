using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_StaticProperties
{//Статические поля и свойства
    class NotStaticClass
    {
        //Статическое поле.
        private static int field; //если я сделаю private int field; - то будет ошибка.
                                  //Мы НЕ можем обращаться ИЗ СТАТИЧЕСКОГО ЧЛЕНА К НЕСТАТИЧЕСКОМУ!
        //Статическое свойство
        public static int Property     //если я сделаю public int Property; - ошибки НЕ БУДЕТ.
        {                              //Мы можем из НЕСТАТИЧЕСКИХ ЧЛЕНОВ обращаться к СТАТИЧЕСКИМ.
            get { return field; }
            set { field = value; }
        }
    }                               //А ЭТО ВСЕ потому, что НЕСТАТИЧЕСКИЕ ЧЛЕНЫ - ПРИНАДЛЕЖАТ ЭКЗЕМПЛЯРУ
                                                            // СТАТИЧЕСКИЕ ЧЛЕНЫ - ПРИНАДЛЕЖАТ ОБЪЕКТУ
}
