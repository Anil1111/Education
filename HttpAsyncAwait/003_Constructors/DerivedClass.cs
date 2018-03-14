using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{
    class DerivedClass:BaseClass
    {
        public int derivedField;
        //Конструктор по умолчанию
        public DerivedClass()
        {
        }

        //Пользовательский констуктор.
        //При создании обьекта производного класса, консткруктор производного класса
        //автоматически вызывает КОНСТУКТОР ПО УМОЛЧАНИЮ из базового  лкасса.
        //Констуктор базового лкасса , присвоит всем полям какие-то безопасные  значения.
        //ПОСЛЕ ЭТОГО начнет работу констуктор производного класса, который повторно
        //будет определять значения для уначледованных членов.(ДВОЙНАЯ РАБОТА)!!
        public DerivedClass(int number1, int number2)
        {
            //Инициализация поля базового класса.
            baseNumber = number1;

            //Инициализация поля производоного (этого) класса
            derivedField = number2;
        }

        public DerivedClass( int number2)
        {
            //Инициализация поля базового класса.
            //baseNumber = number1;

            //Инициализация поля производоного (этого) класса
            derivedField = number2;
        }
    }
}
