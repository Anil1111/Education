using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Constructors
{
    class BaseClass
    {
        public int baseNumber;

        //Конструктор по умолчанию.
        public BaseClass()
        {
        }

        //Пользовательский конструктор.
        public BaseClass(int number)
        {
            this.baseNumber = number;
        }
    }
}
