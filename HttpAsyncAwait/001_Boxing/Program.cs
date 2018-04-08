﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Упаковка  и распаковка.

// Упаковка (Boxing) - преобразование структурного типа (ТИПА ЗНАЧЕНИЯ) в ссылочный тип
// (Object или любой другой тип интерфейса, реализуемый этим типом значения).
// Когда тип значения упаковывается средой CLR, она создает программу-оболочку значения внутри
// System.Object и сохраняет ее в управляемой куче.

// Распаковка (Unboxing) - преобразование ссылочного типа в структурный тип.
// Операция распаковки- преобразования извлекается тип значения из обьекта.
// Перед распаковкой среда выполнения проверяет совместимость между обьектом и стркутурой,
// в которую будет происходить распаковка.
namespace _001_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 25;

            //Упаковка переменной a (Boxing). Может проходить НЕявно
            object o = a;

            //Распаковка обьекта (UnBoxing). Должен проходить ЯВНО.
            short b = (short) o;
            
            //Распаковка должна производится только в ТОТ тип, из КОТОРОГО производилась упаковка.
            //byte s = (byte)o;
        }
    }
}
