﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Strings
{
    // Стрковые литерали. Интернирование строк(реализация паттерна FlyWeight).

    //Среда CLR эконимит пространство для хранения строк, ведя таблицу, называемую пулом интернирования,
    //которая содержит по одной ссылке на каждый уникальный строковой литерал, объявленный или созданный в ...
    //В результате экземпляр строкового литерала с определенным знаением является единствоенным существующим.

    //Например, если один и тот же строковой литера присвоить различным переменным, то среда выполнения
    //извлечт одну и ту же ссылку на литерал из пула интернирования и присвоит ее каждой переменной.

    //Метод Intern использует пул интернирования для писка строки, равной значению str.
    //Если такая строка существует, то возвращается ссылка на нее в пуле интернирования.
    //Если эта строка отсутствует, ссылк на str ДОБАВЛЯЕТСЯ в пул интернирования а затем эта ссылка возвращается
    class Program
    {
        static void Main(string[] args)
        {
            string @string = @"
                              Jack and Jill
                              Wen up the hill...
                              ";
            Console.WriteLine(@string);  //вывелась так, как мы ее написали!

            //Создаем две строки.
            //Эти строковые переменные ссылаются на одно место в памяти потому, что они одинаковы
            // двойной slash нужно ставить потому, что система не поймет, то ли ты хочешь один slash вывести на экрнан, то ли
            //ты хочешь использовать escape последовательности - \n, \r
            string string1 = "c:\\windows\\system"; // в таблицу интернирования попадает без слешей "c:\windows\system";

            //перед созанием, система "бежит" в таблицу интернирования строк и смотрит, есть ли такая строка. Она есть
            //и в переменную string2 присваивается ссылка на эту уже сещуствующий экземпляр строки в пуллле интернирования строк 
            string string2 = @"c:\windows\system"; //если бы string2 попала в таблицу интернирования, то без собаки: "c:\windows\system";

            string takeAaLook = @"qwerty\n"; //а вот при использовании собаки, то у нас нельзя испльзовать escape последовательности 


            //Демонстрация того, что ссылки действительно совпадат.
            Console.WriteLine("string1 = " + string1);
            Console.WriteLine("string2 = " + string2);
            Console.WriteLine("Object.ReferenceEquals(string1, string2) {0}",
                Object.ReferenceEquals(string1, string2)); 

            //Попытка создать ещё одну строковую переменную, которая будет
            //ссылаться на существующий литерал в пуле интернирования.

            Console.WriteLine("\nEnter some string");
            //Метод String.Intern() - извлекает системную ссылку
            //на указанный строковой литерал пула интернирования.

            //string stringNew = Console.ReadLine(); //ввел c:\windows\system и оно создало новый объект в пуле интернирования 
            //ПОТОМУ, ЧТО ПРОВЕРКА ПРОИСХОДИТЬ ТОЛЬКО ВО ВРЕМЯ КОМПИЛЯЦИИ!дальше ее нету и чтобы ее вызвать нужно использовать String.Intern()
            //даже не смотря на то, что такой там уже есть. Соответственно - Object.ReferenceEquals(stringNew, string2) - False

            string stringNew = String.Intern(Console.ReadLine());  //ввел c:\windows\system, а оно побежало в пулл интернирования
            //я спросило "а есть такая строка?", она есть и метод String.Intern вернул ссылку на уже сещуствующую в пулле интернирования строку.

            //Сравнение
            Console.WriteLine("Object.ReferenceEquals(stringNew, string2) {0}",
                Object.ReferenceEquals(stringNew, string2));
            //при обычном  string stringNew = Console.ReadLine(); - вывело False, потому, что не проверяло есть ли такая строка в пулле интернирования и создало ещё одну такую же
            //а при string stringNew = String.Intern(Console.ReadLine());- вывело True - потому, что проверило есть ли такая строка в пулле интерирования и не стало создавать ещё одну.

            Console.WriteLine(stringNew.GetHashCode() + "            " + string2.GetHashCode());
            //если  Object.ReferenceEquals(stringNew, string2) - true, то и hash код`ы одинаковы т.к указуют на один обект.
            //Delay
            Console.ReadKey();
        }
    }
}