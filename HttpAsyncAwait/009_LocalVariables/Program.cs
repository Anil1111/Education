using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_LocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Использование локальный областей и локальных переменных
            //ПРАВИЛО:
            //В коде можно создаваь локальные области и В ДВУХ РАЗНЫХ ЛОКАЛЬНЫХ ОБЛАСТЯХ ХРАНИТЬ ОДНОИМЕННЫЕ ПЕРЕМЕННЫЕ.
            int b = 22;
            //Локальная область 1
            { //       { - это ОТКРЫВАЮЩАЯ операторная скобка. } - это ЗАКРЫВАЮЩАЯ операторная скобка
                int a = 1;
                Console.WriteLine(a); Console.WriteLine(b); //Видим звезды, но не видим микробов
            }
            //Локальна область 2
            {
                int a = 2;
                Console.WriteLine(a);
            }
            //ПРАВИЛО:
            //Если в коде имеются локальные области, то запрещается хранить переменные за пределами локальных областей
            //int b = 1; int b = 1;
            //int a=3; -ЭТО ГЛОБАЛЬНАЯ ПЕРЕМЕННАЯ//ОШИБКА: Переменная с таким именем уже существует в локальной области

            //Delay
            Console.ReadKey();
        }
    }
}
