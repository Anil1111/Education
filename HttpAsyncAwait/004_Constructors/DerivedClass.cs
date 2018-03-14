using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Constructors
{
    class DerivedClass:BaseClass
    {
        public int derivedNumber;

        //Конструктор по умолчанию.
        public DerivedClass()
        {
        }

        //Пользовательский конструктор.
        //Вызывается пользовательский констуктор базового класса, при этом не нужно,
        //присваивать значения, унаследованным членам в конструкторе производного класс,А
        //НУЖНО ПРОСТО НАПИСАТЬ :base(number) И ВЫЗОВЕТСЯ КОНСТРУКТОР БАЗОВОГО КЛАССА 
        //И САМ ВСЕ СДЕЛАЕТ!
        public DerivedClass(int number1, int number2)
        :base(number1)
        {
            this.derivedNumber = number1;
        }
    }
}
