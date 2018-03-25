using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _005_AdditionalTask
{
    class Dictionary
    {   //Цель примера - показать, что в классе может находится несколько индексаторов.
        //Перегрузки индексаторов отличаются друг от друга типом или количеством индексов!  [string index] [int index]
        private string[] RUS = new string[5];
        private string[] ENG = new string[5];
        private string[] UA = new string[5];

        public Dictionary()
        {
            RUS[0] = "книга";
            ENG[0] = "book";
            UA[0] = "книжка";

            RUS[1] = "ручка";
            ENG[1] = "pen";
            UA[1] = "ручечка";

            RUS[2] = "солнце";
            ENG[2] = "sun";
            UA[2] = "сонце";

            RUS[3] = "яблоко";
            ENG[3] = "apple";
            UA[3] = "яблуко";

            RUS[4] = "стол";
            ENG[4] = "table";
            UA[4] = "стіл";
        }

        public string this[string index]  //Разбери детально этот идексатор, что он делает и как хитро он работает.
        {
            get
            {
                for (var i = 0; i < RUS.Length; i++)
                {
                    if (RUS[i] == index )
                        return string.Concat(RUS[i], "-", ENG[i], "-", UA[i]);
                    if (ENG[i] == index)
                        return string.Concat(ENG[i], "-", RUS[i], "-", UA[i]);
                    if (UA[i] == index)
                        return string.Concat(UA[i], "-", ENG[i], "-", RUS[i]);
                }

                return $"Для слова {index} перевода не найдено";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < RUS.Length)
                    return string.Concat(RUS[index], "-", ENG[index],"-",UA[index]);
                return "Попытка обращения за пределы массива";
            }
        }
    }
}

