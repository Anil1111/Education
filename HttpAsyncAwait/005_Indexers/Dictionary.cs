using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _005_Indexers
{
    class Dictionary
    {   //Цель примера - показать, что в классе может находится несколько индексаторов.
        //Перегрузки индексаторов отличаются друг от друга типом или количеством индексов!  [string index] [int index]
        private string[] key = new string[5];
        private string[] value = new string[5];

        public Dictionary()
        {
            key[0] = "книга";
            value[0] = "book";
            key[1] = "ручка";
            value[1] = "pen";
            key[2] = "солнце";
            value[2] = "sun";
            key[3] = "яблоко";
            value[3] = "apple";
            key[4] = "стол";
            value[4] = "table";
        }

        public string this[string index]  //Разбери детально этот идексатор, что он делает и как хитро он работает.
        {
            get
            {
                for (var i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return string.Concat(key[i], "-", value[i]);
                }

                return $"Для слова {index} перевода не найдено";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return string.Concat(key[index], "-", value[index]);
                return "Попытка обращения за пределы массива";
            }
        }
    }
}

