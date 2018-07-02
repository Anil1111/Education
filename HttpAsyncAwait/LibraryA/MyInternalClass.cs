using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryA
{
    //internal - Доступ к типу или члену возможен из любого кода в той же сборке, но не из другой сборки.
    //Если мы подключим этот файл к другому проекту - мы его не увидим.
    internal class MyInternalClass
    {
        public MyInternalClass()
        {
            Console.WriteLine("Конструктор - MyInternalClassA");
        }
    }

    //Класс не может быть помечен как internal protected          (класс не может быть НИ protected НИ internal protected)
    //internal protected class MyInternalClass1 
    //{
    //}
}
