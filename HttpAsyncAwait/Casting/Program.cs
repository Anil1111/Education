﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------- Переменные --------------------------------------
          #region Неявное (безопасное) переобразование типа:
            //Неявное преобразование значение типа  byte-в тип int (преобразование меньшего типа в больший
            byte a = 10;
            int b = 0;
            b = a;
            Console.WriteLine(a);
            //Неявное преобразование значения типа int в тип float (преобазование целого типа в вещественный)
            int c = 255;
            float d = 0f;
            d = c;
            Console.WriteLine(d);
            //Delay
            Console.ReadKey();
            #endregion

          #region Явное (опасное) преобразование типа:
            // Явное преобразование значения типа int в byte
            // Превобразование большего типа в меньший, приводит к потере части результата)
            short e = 255;
            byte f = 0;
            //f = e; Ошибка!
            f = (byte)e; //(byte) - оператор явного перобразования типа
            Console.WriteLine(f);

            //Явное преобразование значяение типа float в тип int.
            //(Преобразование вещественного типа в целый приводит к потере точности)
            float n = 25.4f;
            int m = 0;
            //m = n; Ошибка
            m = (int)n; //(int) - оператор явного перобразования типа
            Console.WriteLine(m);

            //Delay
            Console.ReadKey();
            #endregion
            //---------------------------------------- Константы ---------------------------------------
          #region Кастанг констант
            //Возможно НЕявное преобразование значения константы типа int в тип byte,
            // при инициализации переменной значением константы,
            // ЕСЛИ ЗНАЧЕНИЕ КОНСТАНТЫ НЕ ПРЕВЫШЕЕТ МАКСИМАЛЬНО ДОПУСТИМОГО ЗНАЧЕНИЯ ПЕРЕМЕННОЙ

            const int k = 255;
            byte j = 0;
            j = k;
            Console.WriteLine(j);
            
            //Возможно явное преобразование значения константы типа float в тип byte,
            // при инициализации переменной значением константы,
            // ЕСЛИ ЗНАЧЕНИЕ КОНСТАНТЫ НЕ ПРЕВЫШЕЕТ МАКСИМАЛЬНО ДОПУСТИМОГО ЗНАЧЕНИЯ ПЕРЕМЕННОЙ

            const float r = 255.5f;
            byte t = 0;
            t = (byte)r;
            Console.WriteLine(t);
            Console.ReadKey();
            
            //Не возможно ни явное ни неявное преобразование значения констаты,
            //при инициализации переменной значением константы,
            // если значение константы превышает максимально допустимый диапазон значения переменной

            const int m1 = 256;
            byte n1 = 0;
            //n1 = m1;        ОШИБКА
            //n1 = (byte)m1;  ОШИБКА
            Console.WriteLine(n1);

            //Не возможно ни явное ни неявное преобразование значения ВЕЩЕСТВЕННОЙ констаты,
            //при инициализации ЦЕЛОЧИСЛЕННОЙ переменной значением константы,
            // если значение константы превышает максимально допустимый диапазон значения переменной

            const float o1 = (float)256.5;
            byte p = 0;
            // p = o1;       ОШИБКА
            // p = (byte)o1; ОШИБКА
            Console.ReadKey();
            #endregion
        }
    }
}
