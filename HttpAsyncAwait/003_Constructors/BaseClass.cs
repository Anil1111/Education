using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{//ТЕХНИКА ДВОЙНОЙ ИНИЦИАЛИЗАЦИИ
    class BaseClass
    {
        public int baseNumber;
        
        //Конструктор по умолчанию
        public BaseClass()
        {
        }

        //Пользовательский конструктор
        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
