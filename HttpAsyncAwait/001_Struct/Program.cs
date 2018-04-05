﻿using System;
//Отличия структоры и класса
//1. Конструктор по умолчанию остается всегда. Конструторы по умолчанию нельззя задавать явно.
//2. Работа статического конструктора -> только в сязке с пользовательским.
//3. Нельзя инициализировать НЕ статические поля сразу.
//4. Если в структуре имеются ПОЛЬЗОВАТЕЛЬСКИЙ конструктор, то требуется в нем 
//инициализировать ВСЕ поля. (не считая static полей)
//5. Структура не может быть static т.к структура и так представляет собой некудю СТАТИЧЕСКУЮ СУЩНОСТЬ.
//6. Все завязано на конструктор => если не вызываешь конструктор по умолчанию(а он есть) , а ты создаешь экземпляр
//структорного типа БЕЗ конструктора, то учти, что если поля не проинициазируешь - их использовать нельзя.

namespace _001_Struct
{   //Все локальные пременные, которые мы создаем в методах - ХРАНЯТСЯ В СТЕКЕ!
    //Если это переменная ссылочного типа, то она (т.е ссылка на обьект на куче) будет хранится в СТЕКЕ
    //а сам обьект - будет хранится на куче!

    struct MyStruct
    {
        public int field;
        //public int field2 = 55;  нельзя инициализировать НЕ статические поля сразу.
        public static int field3=555;  //Статические - можно.
        public static int field4;
    }
    class Program
    {
        static void Main(string[] args) //ключевое слово new - обозначает создать экземпляр НА КУЧЕ. тут такого слова нету.
        {
            //Создание экземпляра структорного типа БЕЗ ВЫЗОВА КОНСТРУКТОРА.
            MyStruct instance;

            instance.field = 33; //Закоментировать

            //Попытка вывода значения неинициализированного поля приведет к ошибке
            Console.WriteLine(instance.field);

            MyStruct.field4 = 555;// и это закоментируй - ошибки не будет.
            Console.WriteLine(MyStruct.field4);
            //Delay
            Console.ReadKey();
        }
    }
}