using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ПРАВИЛО:
            //Все арфиметические операции , производимые над двумя значениями типа (byte,sbute,short,ushort)
            //в качестве результата возвращают значение типа int.

            //Присвоение со сложением для типа byte.
            byte variable1 = 0;
            //variable1 = variable1 + 5;       //ОШИБКА: Попытка неявного преобразования (5 -у нас int) в тип byte
            //variable1 = (byte)variable1 + 5; //ОШИБКА: Происходит преобразование типа byte в тип byte,
                                                       //а (5 - int) никто не преобразовывает
            variable1 = (byte)(variable1 + 5); //Громодское решение
            variable1 += 5;                    //Элегентное решение.+= -ЭТО ОПЕРАТОР СЛОЖЕНИЯ С ПРИСВОЕНИЕМ

            //variable1 += 5000;                 //ОШИБКА т.е 5000 не входит в диапазон byte

            //ПРАВИЛО:
            // Для типов int, uint, long, ulong, не происходит преобразования типа результата арифметических операций.
            #region Операцияя присвоения с...
            
            // Присвоение со сложением.
            int variable2 = 0;
            variable2 = variable2 + 5;
            variable2 += 5;

            // Присвоение с вычитанием.
            uint variable3 = 0;
            variable3 = variable3 - 5;
            variable3 -= 5;

            //Присвоение с умножением.
            long variable4 = 1;
            variable4 = variable4 * 5;
            variable4 *= 5;

            //Присвоение с делением.
            ulong variable5 = 1;
            variable5 = variable5 / 5;
            variable5 /= 5;

            //Присвоение остатка от деления.
            long variable6 = 14;
            //variable6 = variable6 % 5;
            variable6 %= 5;
            Console.WriteLine(variable6); //Выведет 4 
            #endregion
            //ПРАВИЛО:
            // Для типов float и double не происходит преобразования типа результата арифметических операций.
            Console.ReadLine();
        }
    }
}
