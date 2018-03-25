using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Indexers
{
    class MyClass
    {
        private string[] array = new string[5];

        //Индексатор
        public string this[int index]  //Создаем СТРОКОВОЙ индекстор с ЦЕЛОЧИСЛЕННЫМ индексом с 2-мя методами доступа -get и set
        {
            get //Аксессор
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
            set  //Мутатор
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
    }
}
